﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

int DayNumber(int num)
{
while (num > 7)
{
    if (num == 1) Console.WriteLine("Понедельник");
}
}

int nameWeek = DayNummber(dayNumber);
Console.WriteLine("Понедельник");