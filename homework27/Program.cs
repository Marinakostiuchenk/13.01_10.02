﻿// 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  452 -> 11
//  82 -> 10
//  9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int sum = 0;
    if (num < 0) num = num * -1;
    while (num > 0)
  {
    sum += num % 10;
    num = num / 10;
  }
  return sum;
  }

int sumDigit = SumDigit(number);
Console.WriteLine(sumDigit);