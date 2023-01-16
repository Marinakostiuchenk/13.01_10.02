Console.WriteLine("Напишите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = number % 2;
int count = 0;

while (count < number)
{
if (x == 0)
{
    count += 2;
    Console.Write($"{count} ");
}
else if (x != 0)
{
    x += 1;
    count += 2;
    number -= 1;
    Console.Write($"{count} ");
}
}
