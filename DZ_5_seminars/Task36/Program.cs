// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// 2. Сумма элементов с нечётными индексами 1, 3, 5
// i = 1; i = i +2;
// summ = summ + array[i]


Console.Clear();
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте диапазон чисел массива: ");
Console.Write("От: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("До: ");
int max = Convert.ToInt32(Console.ReadLine());

// создаём массив с заданными параметрами. ОБЩИЙ МЕТОД
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i <= size - 1; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// метод для печати массива
void PrintArray(int[] array)
{
    Console.Write("[");
    int last = 0;
    if (array.Length > 1)
    {
        for (int i = 0; i <= array.Length - 2; i++)
        {
            Console.Write($"{array[i]}, ");
            last = i;
        }
        last = last + 1;
        Console.Write(array[last]);
    }
    else Console.Write(array[last]);
    Console.Write("]");
}

// метод для подсчёта суммы элементов массива с нечётным индексом
int CounterSummNotEvenNum(int[] array)
{
    int summNotEven = 0;
    for (int i = 1; i <= array.Length - 1; i = i + 2)
    {
        summNotEven = summNotEven + array[i];
    }
    return summNotEven;
}

// создаём массив
int[] newAr = CreateArrayRndInt(size, min, max);
// печатаем массив
PrintArray(newAr);
// находим сумму элементов с нечётными индексами
int summ = CounterSummNotEvenNum(newAr);
Console.WriteLine();
Console.WriteLine($"Сумма элементов элементов с нечётными индексами --> {summ}");


