// Задача 23

// берём число пользователя. целое, не меньше 1 (то есть >= 1 или !< 1)
// Возводим первое число в куб, распечатываем число и результат. прибавляем к счётчику 1
// пока счётчик (=1) не станет больше числа(N) выолняем это действие!

Console.Clear();
int numUser = -1;
while (numUser < 1)
{
    Console.WriteLine("Введите натуральное число: ");
    numUser = Convert.ToInt32(Console.ReadLine());
    if (numUser < 1) Console.WriteLine("Введены неверные данные: ");
}

string ThirdDegree(int number)
{
    int count = 1;
    string table = "";
    while (count <= number)
    {
        table = table + $"{count} | {count * count * count} \n";
        count++;
    }
    return table;
}

Console.WriteLine($"Таблица кубов цифр от 1 до {numUser} \n{ThirdDegree(numUser)}");