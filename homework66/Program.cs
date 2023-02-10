// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// M = 8; N = 4. -> 

Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
 
{
    int tmp = num2;
    num2 = num1;
    num1 = tmp;
}

int SumDigits(int num1, int num2)
{
    return num1 > num2 ? 0 : num1 + SumDigits(num1 + 1, num2);
}
Console.WriteLine($"{SumDigits(num1, num2)}");

// int sum = Sum(num1, num2);
// Console.WriteLine(sum);



// int Sum(int num1, int num2)
// {
//     int sum = 0;
//     for (int i = 0; i < num1 || i < num2 + 1; i++) sum += i;
//     return sum;
// }

