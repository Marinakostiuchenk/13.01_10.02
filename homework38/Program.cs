// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] FillArrayDouble(int size, int min, int max) 
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * ((max - min) + min), 2);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
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
    double maxDigit = array[0];
    double minDigit = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxDigit) maxDigit = array[i];
        if (array[i] < minDigit) minDigit = array[i];
    }
    double difference =  maxDigit - minDigit;
    return difference;
}

double[] array = FillArrayDouble(5, 0, 100);
PrintArrayDouble(array);

Console.Write("-> ");

double diffMaxMin = Math.Round(DiffMaxMin(array), 1);
Console.WriteLine($"{diffMaxMin}");