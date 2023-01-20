// 17. Напишите программу, которая принимает 
// на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта 
// точка.

Console.WriteLine("введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.Readline());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.Readline());

int quarter = Quarter(x, y);
string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти - {quarter}" 
                : "Введены некорректные координаты";
Console.WriteLine(result);

//метод создаем для возвращения числа четверти
int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}
