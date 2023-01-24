// 25. Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
//  3, 5 -> 243 (3⁵)
//  2, 4 -> 16

Console.Write("Введите число А: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// int Degree(int num1, int num2)
// {
//     int count = 1;
//     while (count != num1)
//     {
//        num2 *= num2;
//        count++;
//     }
//     return num1;
// }

int Degree(int num1, int num2)
{
    int count = 1;
    for (int i = 1; i != num2; i++)
    {
       num1 *= num1;
       count = i; 
    }
    return count;
}

int degree = Degree(firstNumber, secondNumber);
Console.WriteLine(degree);


// if (secondNumber > 0) 
// {
//     double degree = Math.Pow(firstNumber, secondNumber);
//     Console.Write(degree);
//     Console.WriteLine(); //для красоты
// }
// Console.WriteLine("Вы ввели неверное число В");


