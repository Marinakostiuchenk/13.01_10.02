// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int SecondDigit(int num)
{
    if (num > 99 && num < 1000)
    {
    int num1 = num / 10 % 10;
    Console.WriteLine($"{num1}");
    }
    else
    Console.WriteLine("Неверное число");
return num;
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
SecondDigit(number);