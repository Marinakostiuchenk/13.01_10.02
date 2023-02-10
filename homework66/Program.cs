// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

SumDigits(num1, num2);

void SumDigits(int num1, int num2)
{
    // Console.Write($"{num1} ");
    if(num1 == num2) return;
    if(num1 > num2)
    {
    SumDigits(num1 - 1, num2);
    }
    else
    {
        SumDigits(num1 + 1, num2);
    }
    Console.Write($"{num1} "); 
}