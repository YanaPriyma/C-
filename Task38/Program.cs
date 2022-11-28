// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
 {
    double[] arr = new double[size];
    Random rnd = new Random();
    
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
 }

 void PrintArray (double[] arr)
 {
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i],1)}, ");
        else Console.Write($"{Math.Round(arr[i],1)}");
    }
    Console.Write("]");
 }

 double DeltaMaxMin(double[] arr)
 {
    double delta = 0 ; 
    double max = Int32.MinValue;
    double min = Int32.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    delta = Math.Round(max - min, 1);
    return delta;
 }

double[] array = CreateArrayRndDouble(5, 1, 100);
PrintArray(array);
double deltaMaxMin = DeltaMaxMin(array);
Console.WriteLine($" -> {Math.Round(deltaMaxMin,1)}");
