// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
// печатаем одномерный массив
void PrintArr(int[] arr)
{
    int last = 0;
    if (arr.Length > 1)
    {
        for (int i = 0; i <= arr.Length - 2; i++)
        {
            Console.Write($"{arr[i]}, ");
            last = i;
        }
        last = last + 1;
        Console.Write(arr[last]);
    }
    else Console.Write(arr[last]);
}

// метод для нахождения сумм элементов в строках. На выходе массив одномерный
int[] FindSummRows(int[,] matr)
{
    int k = 0;
    int summ = 0;
    int[] arr = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            summ = matr[i, j] + summ;
        }
        arr[k++] = summ;
        summ = 0;
    }

    return arr;
}

// метод для нахождения минимального числа в одномерном массиве
int FindMinElementsArray(int[] arr)
{
    int minimal = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minimal) minimal = arr[i];
    }
    return minimal;
}

// находим сколько раз число встречается в одномерном массиве
int HowManyNumbersEqual(int[] arr, int findNum)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == findNum) counter++;
    }

    return counter;
}

// метод для нахождения индекса искомого элемента
int FindIndexElements(int[] arr, int find)
{
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (find == arr[i]) index = i;

    }

    return index;
}

// метод для нахождения индекса искомого элемента. Универсальный для нескольких элементов ОДНОГО НОМИНАЛА
int[] FindIndexElementsUniversal(int[] arr, int find, int howMany)
{
    int k = 0;
    int[] newArr = new int[howMany];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == find)
        {
            newArr[k++] = i;
        }
    }
    return newArr;
}


int[,] array2D = CreateMatrixRndInt(12, 3, 0, 1);
PrintArray(array2D);
Console.WriteLine();

int[] array = FindSummRows(array2D);
Console.WriteLine();

// находим минимальную сумму из всех
int min = FindMinElementsArray(array);

// делаем проверку на то, сколько раз минимальное число встречается в массиве
int howManyMin = HowManyNumbersEqual(array, min);
if (howManyMin > 1)
{
    // если минимальных элементов несколько, тогда и индексов будет выведено соответствующее кол-во
    Console.WriteLine($"минимальная сумма                    --> {min}");
    Console.WriteLine($"Колличество минимальных сумм         --> {howManyMin}");
    int[] newArray = FindIndexElementsUniversal(array, min, howManyMin);
    Console.Write($"Индексы строк с минимальными суммами --> ");
    PrintArr(newArray);
    Console.WriteLine();
}
else
{
    int indexMinSumm = FindIndexElements(array, min);
    Console.WriteLine($"минимальная сумма --> {min}");
    Console.WriteLine($"Строка с минимальной суммой --> строка № {indexMinSumm + 1}");
}


