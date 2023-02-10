// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

GapNaturalNumbers(num1, num2);

void GapNaturalNumbers(int num1, int num2)
{
    // Console.Write($"{num1} ");
    if(num1 == num2) return;
    if(num1 > num2)
    {
    GapNaturalNumbers(num1 - 1, num2);
    }
    else
    {
        GapNaturalNumbers(num1 + 1, num2);
    }
    Console.Write($"{num1} "); 
}