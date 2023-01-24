// 25. Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
//  3, 5 -> 243 (3⁵)
//  2, 4 -> 16

Console.Write("Введите число А: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber > 0) 
{
    double degree = Math.Pow(firstNumber, secondNumber);
    Console.Write(degree);
    Console.WriteLine(); //для красоты
}
Console.WriteLine("Вы ввели неверное число В");
