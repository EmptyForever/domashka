// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

double AckermannFunction(double m, double n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.WriteLine("Введите число m: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"AckermannFunction(m = {num1}, n = {num2}) == {AckermannFunction(num1, num2)}");
