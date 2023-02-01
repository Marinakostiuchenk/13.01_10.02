// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел для ввода далее: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа: ");
string numbers = Convert.ToString(Console.ReadLine());

int[] CreateArray(int size, ) 
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int Integers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        while (arr[i] > 0)
        count++;
    }
    return count;
}

int[] array = CreateArray(size, min, max);
PrintArray(array);
int integers = Integers(array);
Console.WriteLine(integers);

