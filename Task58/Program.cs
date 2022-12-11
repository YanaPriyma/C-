// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

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

int[,] resultMatrix(int[,] m1, int[,] m2)
{
    int m1Rows = m1.GetLength(0), m1Columns = m1.GetLength(1);
    int m2Rows = m2.GetLength(0), m2Columns = m2.GetLength(1);
    int[,] result = new int[m1Rows, m2Columns];
    for (int i = 0; i < m1Rows; i++)
    {
        for (int j = 0; j < m2Columns; j++)
        {
            for (int k = 0; k < m1Columns; k++)
            {
                result[i, j] += m1[i, k] * m2[k, j];
            }
        }
    }
    return result;
}

int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] resMatrix = resultMatrix(matrix1, matrix2);
PrintMatrix(resMatrix);

