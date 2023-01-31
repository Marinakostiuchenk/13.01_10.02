// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101 3 -> 11 2 -> 10

Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// string Recursia(int num)
// {
//     string i = string.Empty;

//     while (num > 0)
//     {
//         if (num % 2 == 0)
//         {
//             i = 0;
//             num = num / 2;
//         }
//         else 
//         {
//             i = 1;
//             num = num / 2;
//         }
//     }
//     return i;
// }

// string res  = Recursia(number);
// Console.WriteLine(res);

//ЧЕРЕЗ СТРОКУ:
string InverseNumber(int num)
{
    string res = string.Empty;
    while (num > 0)
    {
        res = num % 2 + res; // сначала остаток от деления, потом результат
        num /= 2;
        
    }
    return res;
}
string inverseNumber = InverseNumber(number);
Console.WriteLine(inverseNumber);


//ЧЕРЕЗ ЧИСЛО:
// int BinaryNumber(int num)
// {
//     int res = 0;
//     int count = 1;
//     while (num > 0)
//     {
//         res += num % 2 * count;
//         num /= 2;
//         count *= 10;
//     }
//     return res;
// }
// int binaryNumber = BinaryNumber(number);
// Cpnsole.WriteLine(binaryNumber);