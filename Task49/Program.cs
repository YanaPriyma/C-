// See https://aka.ms/new-console-template for more information

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

 void CreateSquare(int[,] matrix)
 {  
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];   
        }
    }
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

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
CreateSquare(array2d);
PrintMatrix(array2d);