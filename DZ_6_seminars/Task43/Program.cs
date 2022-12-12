// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.WriteLine("Задайте параметры для первой прямой --> y = k1 * x + b1 : ");
Console.Write("k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте параметры для первой прямой --> y = k2 * x + b2 : ");
Console.Write("k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());


// метод для нахождения точки пересечения двух прямых. Аргументы - k иксов и c 
double[] CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = default;
    double y = (k1 * b2 - k2 * b1) / (k1 - k2);
// для k1 == 0 мы просто пользуемся другой кусочкек системы неравенств
    if (k1 == 0) 
    {
        x = (y - b2) / k2;
    }
    else 
    {
        x = (y - b1) / k1;
    }
    return new double[2] { x, y };
}


if (k1 == k2)
{
    if (b1 == b2) Console.WriteLine("Заданные прямые совпадают");
    else Console.WriteLine("Заданные прямые параллельны и никогда не пересекаются");
}
else 
{
    double[] array = CrossPoint(k1, b1, k2, b2);
    Console.WriteLine($"\nk1 = {k1}, b2 = {b1}, k2 = {k2}, b2 = {b2}  \nКоординаты x и y точки пересечения --> ( {array[0]}; {array[1]} )");
}