// 54 Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

// метод для сортировки элементов построчно
void SortMatrixRow(int[,] matr)
{
    int temp = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int count = 0; count < matr.GetLength(1) - 1; count++)
        {
            for (int j = 1; j < matr.GetLength(1); j++)
            {//swap elements

                if (matr[i, j] > matr[i, j - 1])
                {
                    temp = matr[i, j - 1];
                    matr[i, j - 1] = matr[i, j];
                    matr[i, j] = temp;
                }
            }
            // j = 0;
        }
    }
}

int[,] array2D = CreateMatrixRndInt(5, 5, 0, 10);
PrintArray(array2D);
Console.WriteLine();
SortMatrixRow(array2D);
PrintArray(array2D);
Console.WriteLine();