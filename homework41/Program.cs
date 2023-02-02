// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите количество чисел для ввода далее: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size) 
    {
    int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    int count = 0;
    Console.WriteLine("Введите числа: ");
    int num = Convert.ToInt32(Console.ReadLine());
    arr[i] = num;
}
return arr;
}
// int Integer(numbers)
// if (num > 0) {count++;}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] array = CreateArray(size);
PrintArray(array);
// int integers = Integers(array);
// Console.WriteLine(integers);

