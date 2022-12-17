// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// создаём двумерный массив с рандомными вещ-венными числа. выводи из метода double [,] 
// в массиве округляем числа вещественные до одного знака после запятой


// создаём двумерный массив вещественных чисел. ---> ОКРУГЛЯЕМ ЧИСЛА ДО 1 ЗАПЯТОЙ
double[,] CreateMatrRndDouble(int rows, int columns, int min, int max)
{
    double[,] matr = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
        }
    }
    return matr;
}


// печатаем двумерный массив
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

double[,] newMatr = CreateMatrRndDouble(3,4,-10,10);
PrintArray(newMatr);