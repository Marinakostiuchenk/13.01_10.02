// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
    int[] result = new int[matrix.Length]; // matrix.Length - общее количество в двумерном массиве
    int count = 0;
    int[,] replaceMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[count++] = matrix[i, j];
        }
    }
    return result;
}

void Frequency(int[] arr)
{
    int tmp = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == tmp) count++;
        else 
        {
        Console.WriteLine($"{tmp} - {count}");
        tmp = arr[i];
        count = 1;
        }
    }
    Console.WriteLine($"{tmp} - {count}");
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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] ");
}

int[,] matr = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matr);
Console.WriteLine();
int[] arr = MatrixToArray(matr);

Array.Sort(arr); // только здесь можно использовать
PrintArray(arr);
Console.WriteLine();
Frequency(arr);

