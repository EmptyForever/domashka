Console.Clear();

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//принимаем три числа пользователя, берём за максимальное первое число, сравниваем все числа с max. Если число больше max, то оно становится max

Console.WriteLine("Введите три числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (max < num1){ max = num1;}
if (max < num2){ max = num2;}
if (max < num3)
{
    max = num3;
}

Console.WriteLine($"{max}");


