// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SummNum(int first, int second)
{
    if (first == second) return first;
    if (first < second)
    {
        return first + SummNum(first + 1, second);
    }
    return first + SummNum(first - 1, second);
}

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от {n} до {m} --> {SummNum(n, m)}");
