// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] MinSumElements(int[,] matrix)
{
    
    int size = matrix[matrix.GetLength(0), matrix.GetLength(1)];
    int[] arr = new int[size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[size] = matrix[i, j];
        }
    }
    return arr[size];
}

double[] GetArithmeticMeanRows(double[,] matrix)
{
    double[] arrayArithmeticMeanRows = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        arrayArithmeticMeanRows[j] = Math.Round(sum / matrix.GetLength(0), 2);
    }
    return arrayArithmeticMeanRows;
}

string PrintArray(int[] arr) //через СТРОКУ, а она медленнее инта
{
    string array = ($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
       array = array + ($", {arr[i]}");
    }
    return array;
}

int[,] matr = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matr);
Console.WriteLine();
int[] array = MinSumElements(arr);
PrintArray(array);