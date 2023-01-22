// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. 
// 14212 -> нет 
// 12821 -> да 
// 23432 -> да 

bool Digit(int num)
{
    return num / 1000 / 10 == num % 100 % 10 && num / 1000 % 10 == num % 100 / 10;
}   

Console.WriteLine("Напишите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 99999 || number < 10000)
{
    Console.WriteLine("Неверное число");
    number = Convert.ToInt32(Console.ReadLine());
}

while (number < 100000 && number > 1000)
{
bool res = Digit(number);
Console.WriteLine(res ? "да" : "нет");
break;
}
