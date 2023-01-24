// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N. 
// 4 -> 24 5 -> 120


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Factorial(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
       sum *= i; 
    }
    return sum;
}

int sumDigit = Factorial(number);
Console.WriteLine(sumDigit);

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number <= 0) Console.WriteLine("Некорректный ввод");

// int Factorial(int num)
// {
//     int result = 1;
//     int counter = 1;
//     while (counter <= number)
//     {
//         result *= counter;
//         counter++;
//     }
//     return result;
// }

// int factorial = Factorial(number);
// Console.WriteLine(factorial);
