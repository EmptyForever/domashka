Console.Clear();
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// принимаем целое число от пользователя; если число больше либо равно 2 - тогда печатаем 2, если нет - тогда никаких чисел
// Также если num больше count - делаем цикл: пока num больше ЛИБО РАВНО count, печатаем count в строку и прибавляем 2(+2), count начианется с двойки
Console.WriteLine("Все чётные числа от 1 до N");
Console.Write("Задайте число N :");

int num = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (num < 2)
{
    Console.Write("Таких чисел не нашлось. Либо в условии просто не сказано, что с отрицательными числами надо тоже поработать. Я бы сделал, да вот бежать надо");
}
if (num >= 2) 
{
    while (num >= count)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
}

