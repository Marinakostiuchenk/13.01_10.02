// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Задайте номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 4)
{
    string range = Range(number);
    Console.WriteLine($"{range} четверти соответствуют координаты: {range}");
}
// else
// {
//     string error = Range(number):
//     if (error == "Ошибка")
//     {
//         Console.WriteLine("Ошибка");
//     }
// }

string Range(int num)
{
    if (num == 1) return "xc > 0, yc > 0";
    if (num == 2) return "xc < 0, yc > 0";
    if (num == 3) return "xc < 0, yc < 0";
    if (num == 4) return "xc > 0, yc < 0";
    return "ошибка";
}