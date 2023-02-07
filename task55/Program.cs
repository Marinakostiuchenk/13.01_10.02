// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1 
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}





void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|"); for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int[,] matr = CreateMatrixRndInt(4, 4, 0, 100);

int[,] Matrix2(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            matrix[i, j] = matrix[j, i];
        }   
    }
    
    }
else
{
    Console.WriteLine("Это невозможно");
}
matrix[i, j];
}

PrintMatrix(matr);
