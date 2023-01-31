// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123 
// [5, 18, 123, 6, 2] -> 1 
// [1, 2, 3, 6, 2] -> 0 
// [10, 11, 12, 13, 14] -> 5

int[] GenArray(int size, int min, int max) 
{
    int[] arr = new int[size];
    Random rnd = new Random(); 
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} " );
    }
}

int ReturnNumberElements(int[] array, int min, int max)
{
    int numberElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
        {
            numberElem++;
        }
    }
    return numberElem;
}
int[] array = GenArray(5, 0, 100); //можно без ввода - сразу цифры подставить здесь, убрав 4 строки выше
PrintArray(array);

int returnNumberElements = ReturnNumberElements(array, 10, 99);
Console.WriteLine($" -> {returnNumberElements}");