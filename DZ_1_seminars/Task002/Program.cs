Console.Clear();

//берём два числа от пользователя, сравниваем их и выводим максимальное

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int max;
if (number1 > number2)
{
    max = number1;
    Console.WriteLine($"Максимальное число {max}");
} 
else if (number1 < number2) {
    max = number2;
    Console.WriteLine($"Максимальное число {max}");
} else {
    Console.WriteLine("Эти числа равны");
}