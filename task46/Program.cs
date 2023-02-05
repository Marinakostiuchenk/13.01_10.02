﻿// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами. 
// m = 3, n = 4. 1 4 8 19 5 -2 33 -2 77 3 8 1

//  0  1 2 3
//0  0  1 4 8 19
//1  5 -2 33 -2
//2  77  3  8  1
//3
// int[,] CreateMatrixRndInt(int rows, int colums, int min, int max) 
// {
//     int[,] matrix = new int[rows, colums]; //как аналог массива 0 -cтроки, 1 - столбцы
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength; i++) // i - внешний цикл (гетленс содержит 3)
//     {
//         for (int j = 0; j < matrix.GetLength; j++) //внутренний (гетленс содержит 4)
//         {
//            matrix[i, j] = rnd.Next(min, max + 1); // проходим по строкам [0, 1] [0, 2] [0, 3]
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//     Console.Write("|");
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3} | ");
//         else Console.Write($"{matrix[i, j], 3} ");
//     }
//     Console.Write("| ");
//     }
// }

// int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
// PrintMatrix(array2D);




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

int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);