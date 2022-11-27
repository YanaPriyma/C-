// проверяет есть ли заданное число в массиве

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

 bool FindNumber(int[] arr, int num)
 {
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
 }

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.Read());
Console.WriteLine(FindNumber(array, number) ? "Да" : "Нет");