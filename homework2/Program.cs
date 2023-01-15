Console.WriteLine("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber > secondnumber)
{
    Console.WriteLine($"max = {firstnumber} ");
}
else
{
    Console.WriteLine($"max = {secondnumber} ");
}
