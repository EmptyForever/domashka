// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// принимаем число пользователя. Проверяем входит ли оно в диапазон от 1 до 7 [1, 7]
// Есил нет, то пофигу ващпе. Если да, идём дальше
// От одного до 5 - нет, не выходной. 6 или 7 - да, выходной. [1, 5] - no [6, 7] - yes
Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (1 >= number || number <= 7)
{
    Console.WriteLine("Является ли этот день выходным?");
    if (1 >= number || number <= 5)
    {
    Console.WriteLine("нет");
    }
    else Console.WriteLine("да");
}
else {Console.WriteLine("Это не день недели!");}

// if (1 >= number || number <= 7)
// {
//     Console.WriteLine("Является ли этот день выходным?");
//     if (1 >= number || number <= 5)
//     {
//     Console.WriteLine("нет");
//     }
//     else if (6 == number || number == 7)
//     {
//     Console.WriteLine("да");
//     }
// }
// else
// {
//     Console.WriteLine("Это не день недели!");
// }

