// принимаем число пользователя
Console.Clear();
Console.WriteLine("Возводим число a в натуральную степень числа b");
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
while (b < 1) 
{
    Console.Write("Введите натуральное число b (целые положительные числа от 1): ");
    b = Convert.ToInt32(Console.ReadLine());
}

// метод для возведения числа в натуральную степень
int Exponentiation(int num, int degree)
{
    int result = num;
    for (int i = 0; i < degree -1; i++)
    {
        result = result * num;
    }
    return result;
}

int exponentAB = Exponentiation(a, b);
Console.WriteLine(exponentAB);