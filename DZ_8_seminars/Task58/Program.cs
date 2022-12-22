// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// метод для умножения матриц
int[,] MultiplyMatrix(int[,] firstMatr, int[,] secondMatr)
{
    int summ = 0;
    int[,] newMatr = new int[firstMatr.GetLength(0), secondMatr.GetLength(1)];
    for (int i = 0; i < newMatr.GetLength(0); i++)
    {
        for (int j = 0; j < newMatr.GetLength(1); j++)
        {
            for (int temp = 0; temp < firstMatr.GetLength(1); temp++)
            {
                summ = summ + firstMatr[i, temp] * secondMatr[temp, j];
            }
            newMatr[i, j] = summ;
            summ = 0;
        }
    }

    return newMatr;
}

// создаём двумерный целочисленный массив
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// печатаем двумерный целочисленный массив
void PrintMatr(int[,] matrix)
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



int[,] array2D = CreateMatrixRndInt(3, 2, 0, 10);
PrintMatr(array2D);
Console.WriteLine();

int[,] array2DSecond = CreateMatrixRndInt(2, 4, 0, 10);
PrintMatr(array2DSecond);
Console.WriteLine();

Console.WriteLine($"Находим произведение двух заданных матриц");
if (array2D.GetLength(1) == array2DSecond.GetLength(0))
{
    Console.WriteLine("Первую матрицу можно умножить на вторую!");
    Console.WriteLine();
    int[,] newMatrix = MultiplyMatrix(array2D, array2DSecond);
    Console.WriteLine("Результат произведения двух матриц. Первой на вторую. Результриющая матрица:");
    PrintMatr(newMatrix);
}
else Console.WriteLine("Первую матрицу нельзя умножить на вторую!");