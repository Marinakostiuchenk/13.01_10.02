
// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива. 

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random(); //заполнили нолями array
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1); //заполнили методом из чисел, которые будут заданы
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int GetSumNegativeElem(int[] array) // сумма отрицательных ищем
{
    int sum = 0; // int sum = default - значени по умолчанию 0
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i];
    }
    return sum;
}

int GetSumPositiveElem(int[] array) // сумма отрицательных ищем
{
    int sum = 0; // int sum = default - значени по умолчанию 0
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);

int sumNegativeElem = GetSumNegativeElem(arr);
int sumPositiveElem = GetSumPositiveElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");
// Console.Write(" -> ["); // но метод для того, чтобы не повторять код
// PrintArray(arr);
// Console.Write(" -> ]");