// принимаем число пользователя и делаем проверки
Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 0)
{
    num = -num;
}
else if (num == 0)
{
    Console.WriteLine("сумма равна нулю");
}

// Находим сколькизначное число (сколько цифр в нём)
int HowManyDigits(int number)
{
    int countNum = 1;
    while (number >= 10)
    {
        number = number / 10;
        countNum++;
    }
    return countNum;
}

// метод для присваивания элементам массива --> соответствующих цифр
int[] AssignValue(int countNumbers, int numUser)
{
    int[] array = new int[countNumbers];
    for (int index = countNumbers - 1; index >= 0; index--)
    {
        array[index] = numUser % 10;
        numUser = numUser / 10;
    }
    return array;
}

// метод для нахождения суммы цифр массива
int SummNumbersArray(int[] array)
{
    int summ = default;
    for (int i = 0; i <= array.Length - 1; i++) 
    {
        summ = summ + array[i];
    }
    return summ;
}

int howDigits = HowManyDigits(num);
int[] array = AssignValue(howDigits, num);
int summNum = SummNumbersArray(array);

Console.WriteLine($"Сумма цифр числа {num} = {summNum}");