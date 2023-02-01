// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.




int ThirdNumber(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}


Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int res = ThirdNumber(num1);
Console.Write(res);

// if (num1 > 99 || num1 < -99)
// {
//     if (num1 < -99)
//     {
//         num1 *= -1;
//     }
// int res = ThirdNumber(num1);
// Console.WriteLine($"{res} ");
// }
// while (num1 < 100 && num1 > -100)
// {
//     Console.WriteLine("Третьей цифры нет");
//     break;
// }
