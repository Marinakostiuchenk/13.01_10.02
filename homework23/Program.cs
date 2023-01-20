// Задача 23 
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N. 
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125
// В виде таблицы.

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Некорректный ввод");
else Table(number);

void Table(int num)
{
    int step = 1;
    while (step <= num)
    {
        Console.WriteLine($"{step,5}   {step * step * step,5}");
        step++;
    }
}