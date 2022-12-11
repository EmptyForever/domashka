// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


// 1. Задать массив вещественных чисел (double). --> +++ округление
// +

// 2. Найти раницу между максимальным и минимальными элементами массива
// 2.1 найти минимальный и максимальный
// 2.1 --> создаём два метода для поиска MAX и MIN элемента массива
// 2.2 находим разницу между ними --> result


// создание вещественного массива СО случайными числами
double[] CreateArrayRndDouble(int count, int min, int max)
{
    double[] array = new double[count];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}

// печать массива --> улучшенный для переноса строки после каждого 17 элемента
void PrintArray(double[] array)
{
    Console.Write("[");
    int last = 0;
    if (array.Length > 20) 
    {
        for (int i = 0; i <= array.Length - 2; i++)
        {
            if (i % 17 == 0 && i !=0)
            {
                Console.Write($"{array[i]}, \n");
                last = i;
            }
            else
            {
                Console.Write($"{array[i]}, ");
                last = i;
            }
        }
        last = last + 1;
        Console.Write(array[last]);
    }
    else 
    {
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
    }
    Console.Write("]");
}

// метод для нахождения MIN элемента массива
double FindMinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

// метод для нахождения MAX элемента массива
double FindMaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

Console.Clear();
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте диапазон чисел");
Console.Write("От: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("До: ");
int max = Convert.ToInt32(Console.ReadLine());

// создаём массив
double[] array = CreateArrayRndDouble(size, min, max);
// печатаем его --> Для наглядности
PrintArray(array);
// находим Min и Max
double minElement = FindMinElement(array);
double maxElement = FindMaxElement(array);
// выводим их в консоль для наглядности

Console.WriteLine($"\nМинимальное число  --> {minElement}");
Console.WriteLine($"Максимальное число --> {maxElement}");
// находим реузльтат --> разницу между ними
double result = maxElement - minElement;
Console.WriteLine();
Console.WriteLine($"Максимальное число - Минимальное число  --> {result}");
Console.WriteLine($"{maxElement} - {minElement} = {result}");
