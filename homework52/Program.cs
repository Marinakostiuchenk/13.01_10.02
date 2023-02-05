// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] CreateMatrixRndInt(int rows, int columns)
{
    double[,] matrix = new double[rows, columns]; // 0, 1 
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(string.Format("{0,5}", matrix[i, j] + " "));
    }
    Console.WriteLine();
}
}

void Average(double[,] matrix)
{
    double average = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average += matrix[i, j] / matrix.GetLength(0);
        }
        Console.WriteLine(string.Format ("Средняя арифметическая в столбце {0} = {1}", j, Math.Round(average, 1)));
        average = 0;
    }
}


double[,] matr = CreateMatrixRndInt(3, 4);
PrintMatrix(matr);
Average(matr);
