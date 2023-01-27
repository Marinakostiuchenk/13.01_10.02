// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21


int[] GenArray(int size, int min, int max) //создание массива в методе
{
    int[] arr = new int[size];
    Random rnd = new Random(); //дальше не нью рандом, а rnd.Next(min, max + 1)
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
        // arr[i] = new Random().Next(min, max + 1); //new Random генерирует ПСЕВДО рандом: 11111
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

int[] ArrayNumberFirstLast(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size += 1;

    int[] arrayNew = new int[size];

    for (int i = 0; i < size; i++)
    {
        arrayNew[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 == 1) arrayNew[arrayNew.Length - 1] = array[array.Length / 2]; //перезаписываем 
    //последним элементом в новом массиве - середину из старого
    return arrayNew;
}

int[] array = GenArray(5, 0, 10); 
PrintArray(array);

int[] arrNew = ArrayNumberFirstLast(array);
PrintArray(arrNew);
