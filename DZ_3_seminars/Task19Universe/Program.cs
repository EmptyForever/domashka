Console.Clear();
Console.WriteLine("введите число: ");
int numUser = Convert.ToInt32(Console.ReadLine());
while (numUser == 0)
{
    Console.Write("Введите число отличное от нуля: ");
    numUser = Convert.ToInt32(Console.ReadLine());
}
if (numUser < 0) //если отрицательные числа можно назвать палиндромами, то мы с ними работаем!
{
    numUser = numUser*(-1);
}
Console.WriteLine("Является ли оно палиндромом?");

int HowManyDigits(int number) // Находим сколькизначнео число (сколько цифр в нём)
{
    int countEx = 1;
    while (number >= 10)
    {
        number = number / 10;
        countEx++;
    }
    return countEx;
}
int count = HowManyDigits(numUser);// применяем функцию по определению колчиества цифр
// Console.WriteLine($"число {count} - значное"); //печатаем кол-во цифр

int notCorrect = 100; //для вывода

int countLeft = 1;
int countRight = count; // скольки значное число = count

int tenInDgreeLeft = 10;//первая слева
int tenInDgreeRight = 1;//первая справа

int numLe = count - 1;
int numRi = 0;

int countDegreeLeft = numLe;
int countDegreeRight = numRi;
while (countLeft <= countRight) //сравниваем два числа
{
countDegreeLeft = numLe;
    while (countDegreeLeft > 1)
    {
        tenInDgreeLeft = tenInDgreeLeft * 10;
        countDegreeLeft--;
    }
    numLe--; //уменьшаем на 1 numLe для следующих действий

countDegreeRight = numRi;
    while (countDegreeRight > 1)
    {
        tenInDgreeRight = tenInDgreeRight * 10;
        countDegreeRight--;
    }
    numRi++;

    int numLeft = (numUser / tenInDgreeLeft) % 10; // цифра слева
    int numRight = (numUser / tenInDgreeRight) % 10;// цифра справа

    // Console.WriteLine($"{numLeft} {numRight}"); //проверки
    // Console.WriteLine($"{tenInDgreeLeft} {tenInDgreeRight}"); //проверки

    if(numLeft == numRight)
    {
        
    }
    else
    {
        notCorrect = 101;
        break;
    }

    countLeft++;
    countRight--;
    tenInDgreeLeft = 10;
    tenInDgreeRight = 10;
}
// correct 101 - true, correct 100 - false
if (notCorrect == 101) 
{
    Console.WriteLine("нет");
} 
else
{
    Console.WriteLine("Да");
}