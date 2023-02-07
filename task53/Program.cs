// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива. 

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

int[,] Rows(int[,] matrix)
{
    int tmp = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        tmp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
       matrix[matrix.GetLength(0) - 1, j] = tmp; 
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
PrintMatrix(matr);
Console.WriteLine();
Rows(matr);
PrintMatrix(matr);