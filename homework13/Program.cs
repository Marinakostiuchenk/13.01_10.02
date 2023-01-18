// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

int ThirdNumber(int num)
{
    return num = num % 10;
}

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

while (num1 > 99 || num1 < 100)
{
    Console.WriteLine("Введите число: ");
}

ThirdNumber(num1);
