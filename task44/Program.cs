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
    array[0] = 0;
    array[1] = 1;
    int sum = 0;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

int[] arr = Fibonacci(number);
PrintArray(arr);




// int[] FillArray(int size, int min, int max) 
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] ");
}

// int Fibonacci(int[] array)
// {
//     array[0] = 0;
//     array[1] = 1;
//     int sum = 0;
//     for (int i = 2; i < array.Length; i++)
//     {
//         array[i] = array[0] + array[1] + array[i];
//     }
//     return array;
// }

// int[] array = FillArray(10, 1, 10);
// PrintArray(array); 

// int res = Odd(array);
// Console.Write($" -> {res} ");