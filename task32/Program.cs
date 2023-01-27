// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот. 
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

//функция создания массива
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random(); //заполнили нолями array
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1); //заполнили методом из чисел, которые будут заданы
    }
}

//функция вывода
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


void Reverse (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1; //array[i] = -array[i]; без array
    }
    return array;
}
//Программа
int[] array = CreateArrayRndInt(4, -10, 10);
PrintArray(array);
int[] reverseArray = Reverse(array);
PrintArray(reverseArray);
