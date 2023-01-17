// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int secondDigit(int num)
{
    int firstNum = num % 100; // 56
    int secondNum = num % 10; // 6
    int res = (firstNum - secondNum) / 10;
    return res;
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = secondDigit(number);
Console.WriteLine($"{res} ");