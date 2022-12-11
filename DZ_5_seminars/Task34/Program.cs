// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// 1 треххначные > 0 массив
// 1.1 создаём массив
// 1.2 присваиваем случайные ему значения от 100 до 999

// 2 кол-во чётных чисел в массиве
// 2.1 создаём счётчик count. увеличиваем его, если в массиве есть число (arra[i] % 2==0) чётное
// 2.2 выводим count

// создаём массив для 34 вопроса
int[] CreateArrayTask34(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i <= size - 1; i++)
    {
        array[i] = rnd.Next(100, 1000);
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

// метод для подсчёта кол-ва чётных элементов
int CounterEvenNumElements(int[] array)
{
    int count = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Clear();
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

// создаём массив RND с заданным размером
int[] addArr = CreateArrayTask34(size);
// печатаем массив для наглядности

// считаем кол-во чётных элементов
int count = CounterEvenNumElements(addArr);
Console.WriteLine();
PrintArray(addArr);
Console.WriteLine();
Console.WriteLine($"Колличество чётных чисел: {count}");