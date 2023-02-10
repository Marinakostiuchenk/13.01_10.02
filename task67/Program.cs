// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр. 453 -> 12 45 -> 9 

Console.WriteLine("Введите числo: ");
int num = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(num);
Console.WriteLine(sumDigit);

int SumDigit(int num)
{
        if (num == 0) return 0;
        
        return num % 10 + SumDigit(num / 10); //453 45 4 - стек данных в рекурсии (сначала выполняется рекурсия) последним выпоняется остаток брать
}
//     int sum = 0;
//     Console.Write($"{num} ");
//     if(num < 10) return;
//     else
//     {
//     while (num > 99)
//     {
   
//         GapNaturalNumbers(num % 10);
//         sum += num;
    
//     }
//     }
//     Console.Write($"{sum} ");
//     // Console.Write($"{num1} "); //- по убыванию (когда внизу - не выводится результат, если оба числа равны)
// }

// ПОДСКАЗКА:
// int Factorial(int n)
// {
// if(n == 1) return 1; 
// else return n * Factorial(n-1); 
// } 
// Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6