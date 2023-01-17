// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.

int DayNumber(int num)
{
    if (num < 6 && num > 0)
    {
        Console.WriteLine("Не выходной");
    }
    else if (num >= 6 && num <= 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Неправильное значение");
    }
return num;
}

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
DayNumber(dayNumber);
