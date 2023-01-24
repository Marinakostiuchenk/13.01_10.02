// 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  452 -> 11
//  82 -> 10
//  9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int count = 0;
    if (num < 0) num = num * -1;

  for (int i = 0; i < length; i++)
  {
      num = num / 10;
      i++;
      }
      return count;
  }


int sumDigit = SumDigit(number);
Console.WriteLine(sumDigit);