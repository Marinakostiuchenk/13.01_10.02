// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N. 
// 5 -> 1, 4, 9, 16, 25. 2 -> 1,4

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Некорректный ввод");
else Table(number);

void Table(int num) //чтобы сохранить данные - это работа с массивом
{
    int step = 1;
    while (step <= num)
    {
        Console.WriteLine($"{step,5}   {step * step,5}");
        step++;
    }
}


// int Table(num, i)
// {
//     int i = 0;
//     while (i < num)
//     {
//     return Math.Pow(num, 2);
//     i += 2;
//     }
// }