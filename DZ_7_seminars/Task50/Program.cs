// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. Или, что таких индексов нет для двумерных массивов
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

// создаём двумерный массив
// Принимаем два числа от пользователя
// выдаём пользователя результат, если всё окей с принятием числа

// 1.new Matr
// 2. Если i || j < 0 , то выдаём CnsWRL --> "Таких индексов нет для двумерных массивов"
// 2. Если i > matr.GetLength(0) - 1 || j > matr.GetLength(1) -1 --> тогда "Такого элемента в массиве нет"
// 2. Иначе идём дальше
// 2.   ---> 3. выдаём пользователя результат. Возвращаем в методе значение matr[i, j] == N


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


// печатаем двумерный целочисленный масив
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


// метод для поиска значения элемента В целочисленном двумерном массиве по его позиции
void FindElements(int[,] matr, int row, int column)
{
    if (row < 0 || column < 0) Console.WriteLine("Таких индексов нет для двумерных массивов");
    else if (row > matr.GetLength(0) - 1 || column > matr.GetLength(1) - 1) Console.WriteLine("Элемента с таким индексом в данном массиве нет");
    else Console.WriteLine($"Значение элемента с позицией ({row}, {column}) --> {matr[row, column]}");
}


int[,] array2D = CreateMatrRndInt(4,5,-10,10);
PrintArray(array2D);

Console.WriteLine("Задайте индексацию искомого элемента");
Console.Write("Индекс строки: ");
int rowUser = Convert.ToInt32(Console.ReadLine());

Console.Write("Индекс столбца: ");
int columnUser = Convert.ToInt32(Console.ReadLine());
FindElements(array2D, rowUser, columnUser);