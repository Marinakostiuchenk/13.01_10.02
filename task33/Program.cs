// Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве. 4; 
// массив [6, 7, 19, 345, 3] -> нет 3;
// массив [6, 7, 19, 345, 3] -> да

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

bool NumberInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) 
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = GenArray(5, 0, 10);
PrintArray(array);
bool numberInArray = NumberInArray(array, number);
Console.WriteLine(numberInArray);