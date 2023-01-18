// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.

bool DayNumber(int num)
{
    return num == 6 || num == 7;
}

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

while (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Вы введи неверное число. Попробуйте снова: ");
    dayNumber = Convert.ToInt32(Console.ReadLine());
}

bool res = DayNumber(dayNumber);
Console.WriteLine(res ? "да" : "нет");