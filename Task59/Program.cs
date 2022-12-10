// Задан двумерный массив. 
//надо удалить столбец и строку на пересечении. где наименьший элемент 
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

void IndexMinElement(int[,] matrix, out int indexRow, out int indexColumn)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int min = matrix[0, 0];
    indexRow = 0;
    indexColumn = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexRow = i;
                indexColumn = j;
            }
        }
    }
}

int[,] RemoveRowColumn(int[,] matrix, int indexRow, int indexColumn)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] matrix2 = new int[rows - 1, columns - 1];
    for (int i = 0, m = 0; i < rows - 1; i++, m++)
    {
        if (m == indexRow) m++;
        for (int j = 0, n = 0; j < columns - 1; j++, n++)
        {
            if (n == indexColumn) n++;
            matrix2[i, j] = matrix[m, n];
            //if (i != indexRow && j != indexColumn)
            //matrix2[m,n] =  matrix[i,j];
        }
    }
    return matrix2;
}

int[,] matrix1 = CreateMatrixRndInt(4, 4, 1, 50);
PrintMatrix(matrix1);
Console.WriteLine();
int rowIndex, columnIndex;
IndexMinElement(matrix1, out rowIndex, out columnIndex);

int[,] matrix3 = RemoveRowColumn(matrix1, rowIndex, columnIndex);
PrintMatrix(matrix3);