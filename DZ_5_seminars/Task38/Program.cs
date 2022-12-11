
// создание вещественного массива СО случайными числами
double[] CreateArrayRndDouble(int count, int min, int max)
{
    double[] array = new double[count];
    int index = 0;
    Random rnd = new Random();
    while (index < array.Length)
    {
        array[index] = rnd.NextDouble() * (max - min) + min;
        index++;
    }
    return array;
}

// печать массива
void PrintArray(double[] array)
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

PrintArray(CreateArrayRndDouble(10, 0, 5));
