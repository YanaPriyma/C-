// найти сумму элементов на главной диагонали 

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
 {
    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max+1);   
        }
    }
    return matrix;
 }

 
 void PrintMatrix (int[,] matrix)
 {
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("|");
    }
 }


int SumDiagonal (int[,] matrix)
{
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, i];
    } 
    return sum;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);
int sum = SumDiagonal(array2d);
Console.WriteLine($"суммв элементов на главной диагонали -> {sum}");

