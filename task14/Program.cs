//1. Напишите программу, которая принимает на вход число 
//2. и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да

bool Multiple(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

Console.WriteLine("Напишите число ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Multiple(number);

if (result) Console.WriteLine("да");
else Console.WriteLine("нет");


