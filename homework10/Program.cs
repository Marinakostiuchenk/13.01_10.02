// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int Digit(int num)
{
   return num / 10 % 10;
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}

if (number > 99 && number < 1000)
{
    int res = Digit(number);
    Console.Write(res);
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}



// int SecondDigit(int num)
// {
//     return num / 10 % 10;
// }

// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// while (number < 100 || number > 999)
// {
//     Console.WriteLine("Неверное число");
//     number = Convert.ToInt32(Console.ReadLine());
// }

// int res = SecondDigit(number);
// Console.WriteLine($"{res}");