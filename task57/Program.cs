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

int[] ArrayFromMatrix(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int count = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[i] = matrix[i, j];
            count++;
        }
    }
    return array;
}

void Frequency(int[] array)
{
    int count = 1;
    int num = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        count++;
        else
        {
            Console.WriteLine($"{num} встречается {count} раз");
            num = array[i];
            count = 1;
        }
    }
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

int[,] matr = CreateMatrixRndInt(4, 4, 0, 100);
PrintMatrix(matr);
Console.WriteLine();
int[] arr = ArrayFromMatrix(matr);
// Array.Sort(arr);
PrintArray(arr);
