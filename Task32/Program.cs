﻿// замаена положительных элементов массива на отрицательные и наоборот

 int[] CreateArrayRndInt(int size, int min, int max)
 {
    int[] arr = new int[size];
    Random rnd = new Random();
    
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
 }

 void PrintArray (int[] arr)
 {
    Console.Write("[");
    for(int i = 1; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] -> ");
 }
 void NegativeArray (int[] arr)
 {
    for(int i = 1; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
 }

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
NegativeArray(array);
PrintArray(array);