Console.WriteLine("Напишите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = n % 2;
int y = 0;

if (n > 0)
{
    if (x != 0)
    {
    x -= 1;
    while (y < n - 1)
    {
        y += 2;
        Console.Write($"{y} ");
    }
    }
    else if (x == 0)
    {
        x += 2;
         while (y < n - 1)
    {
        y += 2;
        Console.Write($"{y} ");
    }
    }
}
