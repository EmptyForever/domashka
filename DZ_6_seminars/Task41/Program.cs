// \\====== пользователь вводит с клавиатуру M чисел. Сколько > 0 ?

// создаём новый массив. size --> Определяет пользователь размер массива. array[i] --> тоже задаёт User
int[] CreateArrayUser(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}


// метод для опеределения кол-ва элементов > 0
int CountMoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) if (array[i] > 0) count++;
    return count;
}


// печать массива
void PrintArray(int[] array)
{
    Console.Write("[");
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
    else Console.Write(array[last]);
    Console.Write("]");
}


Console.Clear();
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] arrayNew = CreateArrayUser(size);
int count = CountMoreZero(arrayNew);
PrintArray(arrayNew);
Console.WriteLine($"\nКол-во элементов > 0  -->  {count}");