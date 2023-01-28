// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] FillArray(int size, int min, int max) 
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] ");
}

double DiffMaxMin(double[] array)
{
    double max = 0;
    double min = 0;
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
         (i % 2 == 0) num += i;
    }
    return num;
}

double[] array = FillArray(5, 0, 100);
PrintArray(array);
Console.Write("-> ");
double[] diffMaxMin = DiffMaxMin(array);
PrintArray(diffMaxMin);