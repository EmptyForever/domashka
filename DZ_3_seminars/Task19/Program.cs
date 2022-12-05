// Задача 19

// пятизначное число -палиндром, если его 1 и 5 цифры равны, 2 и 4, равны 
// находим их и сравниваем. Если да - палиндом, нет - не палиндром


Console.Clear();
int numUser = 999;

while (numUser < 10000 || numUser > 99999)
{
    Console.WriteLine("Введите число 5 значное число: ");
    numUser = Convert.ToInt32(Console.ReadLine());
}
// приняли 5-значное число пользователя
// если его 1 и 5 цифры равны, 2 и 4, равны 
 Console.WriteLine("Является ли оно палиндромом?");

bool Palindrom(int number)
{
    int num1 = number / 10000;
    int num5 = number % 10;
    int num2 = (number / 1000) % 10;
    int num4 = (number / 10) % 10;
    if (num1 == num5 && num2 == num4) return true;
    else  return false;
}
bool palindrom = Palindrom(numUser);
Console.WriteLine(palindrom ? "да" : "нет");











// nCountLast - счётчик начинающийся с последней цифры(счётчик провых цифр)
// countFirst - счётчик первой цифры (счётчик левых цифр)

// пока (nCountLast =< countFirst) -
// делаем : 
//  уменьшаем Last и увеличиваем first