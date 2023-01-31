// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1. 
// Если N = 5 -> 0 1 1 2 3 
// Если N = 3 -> 0 1 1 
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] Fibonacci(int size)
{
    int[] array = new int[size];
    // array[0] = 0; итак всегда с ноля начинается массив
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

int[] arr = Fibonacci(number);
PrintArray(arr);





void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
