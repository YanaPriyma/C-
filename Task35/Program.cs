// задается одномерный массив из 135 чисел, найти количество элементов на [10,99]
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
    Console.WriteLine("]");
 }

 int CounElements(int[] arr)
 {
    int count = 1; 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <=99) count++;
    }
    return count;
 }

int[] array = CreateArrayRndInt(123, 0, 1000);
PrintArray(array);
int countElements = CounElements(array);
if (countElements > 0) Console.WriteLine($"Количество двузначных элементов массива = {countElements}");
else Console.WriteLine("Двузначных элементов нет");