// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] FillArray(int size, int min, int max) 
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}


string PrintArray(int[] arr) //через СТРОКУ, а она медленнее инта
{
    string array = ($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
       array = array + ($", {arr[i]}");
    }
    return array;
}

int[] CopyArray(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}

int[] array = FillArray(5, 1, 9);
int[] copy = CopyArray(array);
// copy[0] = 15; проверка для того, что копия - это отдельный массив
Console.WriteLine($"{PrintArray(array)} -> {PrintArray(copy)}");
