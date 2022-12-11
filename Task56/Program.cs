// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

int[] FindSum(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[] arr = new int[rows];
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum += matrix[i, j];
        }
        arr[i] = sum;
        sum = 0;
    }
    return arr;
}

void MinSumRow(int[] arr)
{
    int min = arr.Min();
    int minRow = new int();
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == min) minRow = i + 1;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");
}

int[,] matrix1 = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(matrix1);
Console.WriteLine();
MinSumRow(FindSum(matrix1));