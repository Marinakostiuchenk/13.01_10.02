Console.WriteLine("Введите первое число: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second_number = Convert.ToInt32(Console.ReadLine());

if (first_number > second_number)
{
    Console.WriteLine($"max = {first_number} ");
}
else
{
    Console.WriteLine($"max = {second_number} ");
}
