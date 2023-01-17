// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

int ThirdNumber(int num)
{
    if (num > 100)
    {
        num = num % 10;
        Console.WriteLine($"{num} ");
    }
    else
    {
        Console.WriteLine("Вы ввели неверное число!");
    }
    return num;
}

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
ThirdNumber(num1);
