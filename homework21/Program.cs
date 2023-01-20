// Задача 21 
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве. 
// A (3,6,8); B (2,1,-7), -> 15.84 
// A (7,-5, 0); B (1,-1,9) -> 11.53 

Console.WriteLine("Напишите первую координату первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите вторую координату первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третью координату первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите первую координату второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите вторую координату второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третью координату второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    return Math.Sqrt(Math.Pow((xc2 - xc1), 2) + Math.Pow((yc2 - yc1), 2) + + Math.Pow((zc1 - zc2), 2));
}

double distance = Distance(x1, y1, z1, x2, y2, z2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками {distanceRound}");

