// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

  void FindElement(int x, int y, int[,] matrix)
 {
    if (x > matrix.GetLength(0) || y > matrix.GetLength(1)) Console.Write($"{x}, {y} -> такого элемента в массиве нет");
    else Console.WriteLine($" -> {matrix[x, y]} ");
 }


Console.WriteLine("Введите число строк массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array2d = CreateMatrixRndInt(row, column, 1, 9);
PrintMatrix(array2d);

Console.WriteLine("Введите индекс искомого элемента (индексация начинается с 0, числа должны быть положительные):");
Console.WriteLine("Введите X (номер строки)");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y (номер столбца)");
int b = Convert.ToInt32(Console.ReadLine());

FindElement(a, b, array2d);

