// Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве. 4; 
// массив [6, 7, 19, 345, 3] -> нет 3;
// массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random(); //заполнили нолями array
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1); //заполнили методом из чисел, которые будут заданы
    }
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

int[] array = CreateArrayRndInt(5, 0, 10);
bool NumberInArray = NumberInArray