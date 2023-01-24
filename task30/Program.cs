
// Варианты написания массива:
// int[] array = new int[8]; -- так создается массив из 8 элементов (восьми нулей)
// int[] array1 = {1,2,3};
// int[] array = new int[8]{1,2,3,4,5,6,7,8};
// int[] array = new int[]{1,2,3,4,5,6,7,8};
// var array = new int[8];
// array[0] = new Random().Next()

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]


int[] array = new int[8];
int[] FillArray(int[] arr)
{
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}
void PrintArray(int[] arr);
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}
array = FillArray(array);
PrintArray(array);


// int[] GenArray(int size, int min, int max) //создание массива в методе
// {
//     int[] arr = new int[size];
//     // Random rnd = new Random(); //дальше не нью рандом, а rnd.Next(min, max + 1)
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1); //new Random генерирует ПСЕВДО рандом: 11111
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} " );
//     }
// }
// int [] array = GenArray(8, 0, 1);
// PrintArray(array);



// int[] GenerateArray(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }
// int[] array = GenerateArray(8, 0, 1);
// PrintArray(array);
