// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1,10);
        Console.Write($"{array[i]} ");
    }
}

RandomArray(array);