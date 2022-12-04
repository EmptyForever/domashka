// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// расстояние между двумя точками - это гипотенуза 
// c^2 = b^2 + a^2
// s^2 = c^2 + h^2 (= b^2 + a^2 + h^2 и всё это под корнем) - искомая величина.
// c, b и a - стороны первого треугол, s  c  и  h - стороны второго треугол

// принимаем от пользователя 6 чисел по 3 на каждую точку. по осям икс, игрек и зет(3D)
// x2 - x1 = a   
// y2 - y1 = b
// c = sqrt(a^2 +b^2)
// z2 - z1 = h
// s = sqrt(h^2 + c^2) == sqrt(h^2 + a^2 +b^2)
// s = sqrt((x2-x1)^2 + (y2-y1)^2 + (z2 - z1)^2)
// находим длину стороны по формуле выше. Печатаем результат

//  С МЕТОДОМ!
// создаём int метод от 6 чисел - переменных иксов игреков и зетов,
// выводим s (return s)
Console.Clear();
Console.WriteLine("Введите координаты первой точки: ");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Pifagor(int xx1, int yy1, int zz1, int xx2, int yy2, int zz2)
{
    double s = Math.Sqrt((xx2 - xx1) * (xx2 - xx1) + (yy2 - yy1) * (yy2 - yy1) + (zz2 - zz1) * (zz2 - zz1));
    double itog = Math.Round(s, 5);
    return itog;
}
Console.WriteLine(Pifagor(x1, y1, z1, x2, y2, z2));