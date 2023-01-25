// 29. Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
//  1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

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
Console.WriteLine("Здайте массив из 8 элементов. Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
int [] array = GenArray(8, min, max); //можно без ввода - сразу цифры подставить здесь, убрав 4 строки выше
PrintArray(array);