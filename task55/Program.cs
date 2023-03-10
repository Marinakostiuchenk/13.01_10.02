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

// тело функции:
int[,] matr = CreateMatrixRndInt(5, 6, 0, 100);
PrintMatrix(matr);
Console.WriteLine();

if (matr.GetLength(0) == matr.GetLength(1)) 
{
    int[,] replaceMatrix = ReplaceMatrix(matr);
    PrintMatrix(replaceMatrix);
}
else
Console.WriteLine("Невозможно заменить строки на столбцы");



// первое решение:
int[,] ReplaceMatrix(int[,] matrix)
{
    int[,] replaceMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int tmp = matrix[i, j];
            replaceMatrix[i, j] = matrix[j, i];  
            matrix[j, i] = tmp;
        }
        
    }
    return replaceMatrix;
}

// //Второй способ решения: (лучше потому что мы не выделяем ячейку памяти)
// void ReplaceRowsColumns(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0) - 1; i++)
//     {
//         for (int j = i + 1; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }
// }



// Array.Sort(array); - сортировка от меньшего к большему