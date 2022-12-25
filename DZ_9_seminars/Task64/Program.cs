// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void PrintNum(int numUser)
{
    if (numUser == 1)
    {
        Console.Write(1);
        return;
    }
    Console.Write($"{numUser}, ");
    PrintNum(numUser - 1);
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 1)
{
    Console.WriteLine("Введите натуральное число // целые числа от 1 и далее: ");
    num = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
PrintNum(num);