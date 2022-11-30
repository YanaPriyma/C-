// создание копии массива путем копирования элементов 

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
    for(int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
 }

int[] CopyArray(int[] arr)
{
    int[] tempArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        tempArr[i] = arr[i]; 
    }
    return tempArr;
}

int[] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);
int[] copy = CopyArray(array);
PrintArray(copy);

