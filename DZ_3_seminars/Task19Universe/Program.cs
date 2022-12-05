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


// КАК Я МЫСЛИЛ. НЕ ОБЯЗАТЕЛЬНО К ПРОЧТЕНИЮ




// для 1234 
// 1000 и 1 - число tendegree
// 100  и 10 - число tendegree

// нам нужно сравнить левое и правое число

// находим все цифры по отдельности. Нашли все
// начинаем сравнивать с двух концов .как? последнее цифра - это всегда число - остаток от деления на 10
// первое - всегда numUser/ 10^(в такой степени, сколько цифр минус один )
// lustNum = numUser % 10;
// firstNum = (numUser / tenInDegree) % 10;



// bool Palindrom(int number)
// {
//     int num1 = number / 10000;
//     int num7 = number % 10;
//     int num2 = (number / 1000) % 10;
//     int num6 = (number / 10) % 10;
//     int num3 = (number / 10000) % 10;
//     int num5 = (number / 100) % 10;

// // 1234321
//     Console.WriteLine(num1);
//     Console.WriteLine(num7);
//     Console.WriteLine(num2);
//     Console.WriteLine(num6);
//     if (num1 == num7 && num2 == num6) return true;
//     else  return false;
// }
// bool palindrom = Palindrom(numUser);
// Console.WriteLine(palindrom ? "да" : "нет");

// while ()
// nCountLast - счётчик начинающийся с последней цифры(счётчик провых цифр)
// countLeft - счётчик первой цифры (счётчик левых цифр)

// пока (nCountLast =< countLeft) -
// делаем : 
//  уменьшаем Last и увеличиваем first


// int num1 = (numUser / 1000000);
// int num2 = (numUser / 100000) % 10;
// int num3 = (numUser / 10000) % 10;

// int num4 = (numUser / 1000) % 10;

// int num5 = (numUser / 100) % 10;
// int num6 = (numUser / 10) % 10;
// int num7 = numUser % 10;
// Console.WriteLine($"{num1} {num2} {num3} {num4} {num5} {num6} {num7}");