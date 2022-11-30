// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество цифр для ввода: ");
int number = Convert.ToInt32(Console.ReadLine());

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

 int[] FillArray ( int num)
 {
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());   
    }
    return arr;
 }

int CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count ++;
    }
    return count;
}

 Console.WriteLine("Начинайте ввод.");
 int[] array = FillArray(number);
 //int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
 PrintArray(array);
 int res = CountPositive(array);
 Console.WriteLine(res);

