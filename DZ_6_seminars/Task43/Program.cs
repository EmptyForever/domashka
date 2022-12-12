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
double[] PeresecLine(double k1, double b1, double k2, double b2)
{
    double y = (k1 * b2 - k2 * b1) / (k1 - k2);
    double x = (y - b1) / k1;
    return new double[2] { x, y };
}

double[] array = PeresecLine(k1, b1, k2, b2);

Console.WriteLine($"( {array[0]}; {array[1]} )");