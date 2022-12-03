﻿// See https://aka.ms/new-console-template for more information

int[,] CreateMatrixRndInt(int rows, int columns)
 {
    int[,] matrix = new int[rows,columns];
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i +j;   
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

int[,] createMatrix = CreateMatrixRndInt(3, 4);
PrintMatrix(createMatrix);
