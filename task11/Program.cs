//1. Напишите программу, которая выводит случайное трёхзначное число 
//2. и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {number}");

int finishNumber = GetNumber(number);
Console.WriteLine($"{number} => {finishNumber}");

int GetNumber(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int res = firstDigit * 10 + lastDigit;
    return res;
}

