Console.Clear();
// создаём репозотирой заполненный нулями из count чисел
int[] CreateArray(int count)
{
    int[] arrayNum = new int[count]; //count ==8
    return arrayNum;
}

// Присваиваем значения вместо нулей. Случайные от min до max
int[] AssignValue(int[] array, int min, int max)
//min max - Next(min, max) = [min, max) = [min, max - 1]
{
    max = max + 1;
    int index = 0;
    Random rnd = new Random(); // для быстрых компов -. Рандом некст - пвсевдарандом, зависящий от времени компа
    while (index < array.Length)
    {
        array[index] = rnd.Next(min, max);
        index++;
    }
    return array;
}

// выводим в консоль наш массив
void PrintArray(int[] array)
{
    int last = 0;
    if (array.Length > 1)
    {
        for (int i = 0; i <= array.Length - 2; i++)
        {
            Console.Write($"{array[i]}, ");
            last = i;
        }
        last = last + 1;
        Console.Write(array[last]);
    }
    else
    {
        Console.Write(array[last]);
    }

}

Console.Write("Введите число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите диапазон чисел, который вы бы желали увидеть в массиве. Например 1 и 5. \nБудут рандомные числа от 1 до 5 включительно. Это [1, 5] \nОт: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("До: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arrayNew = CreateArray(number);
int[] result = AssignValue(arrayNew, min, max);
PrintArray(result);
