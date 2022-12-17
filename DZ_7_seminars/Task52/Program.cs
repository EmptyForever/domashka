// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// создаём целочисленный двумерный массив случайных целых чисел
int[,] CreateMatrRndInt(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}


// метод для поиска среднего арифметического в каждом столбце. Вывод --> массив средних значений по столбцам
double[] FindColumnAverage(int[,] matr)
{
    double[] newArray = new double[matr.GetLength(1)];
    double summ = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            summ = summ + matr[i, j];
        }
        newArray[j] = Math.Round((summ / matr.GetLength(0)), 1);
        summ = 0;
    }
    return newArray;
}


// печатаем массив
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}


// печатаем числа из массива
void PrintArrayNumber(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" ");
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i], 3}, ");
        }
        else
        {
            Console.Write($"{array[i], 3}");
        }

    }
}


int[,] array2D = CreateMatrRndInt(3, 4, -10, 10);
PrintArray(array2D);

double[] array = FindColumnAverage(array2D);
Console.WriteLine($"Список средних арифметических в столбцах данного двумерного массива --> ");
PrintArrayNumber(array);