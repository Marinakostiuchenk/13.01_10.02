// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdNumber(num)
{
    int thirdNumber = num % 10; // 645 => 5
    return thirdNumber;
}

while (number > 100)
{
    int thirdNumber = ThirdNumber(number);
    Console.WriteLine($"{thirdNumber} ");
}
 else (num < 100);
 {
    Console.WriteLine("третьей цифры нет");
 }