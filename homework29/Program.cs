// 29. Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
//  1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] GenArray(int size, int min, int max)
{
int[] arr = new int[size];
    // Random rnd = new Random(); //дальше не нью рандом, а rnd.Next(min, max + 1)
for (int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(min, max + 1); //new Random генерирует ПСЕВДО рандом: 11111
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
int [] array = GenArray(8, 0, 1);
PrintArray(array);