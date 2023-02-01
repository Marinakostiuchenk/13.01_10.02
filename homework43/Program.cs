﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x * (k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

Console.WriteLine("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double intersectionPointForX = Math.Round(IntersectionPointForX(b1, k1, b2, k2), 1);
Console.Write($"({intersectionPointForX});");
double intersectionPointForY = Math.Round(IntersectionPointForY(b1, k1, b2, k2), 1);
Console.WriteLine($" ({intersectionPointForY})");

double IntersectionPointForX (int b1c, int k1c, int b2c, int k2c)
{
    return Convert.ToDouble(b2c - b1c) / (k1c - k2c);
}

double IntersectionPointForY (int b1c, int k1c, int b2c, int k2c)
{
    return Convert.ToDouble(k1c * ((b2c - b1c)) / (k1c - k2c)) + b1c;
}
