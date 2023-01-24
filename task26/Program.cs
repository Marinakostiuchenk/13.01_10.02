// Напишите программу, которая принимает на вход число 
// и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2

Console.WriteLine("Введите число, чтобы посчитать количество цифр в нем: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int count = 0;
    if (num < 0) num = num * -1;

    while (num > 0)
    {
        num = num/10;
        count++;
    }
    return count;
}

int sumDigit = SumDigit(number);
Console.WriteLine(sumDigit);