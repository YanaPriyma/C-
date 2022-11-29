// преобразование десятичного числа в двоичное 

// string Binary (int num)
// {
//     string bin = string.Empty; 
//     while (num > 0)
//     {
//         bin = num % 2 + bin;
//         num /= 2;
//     }
//     return bin;
// }

 void PrintArray (int[] arr)
 {
    for(int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}");
    }

 }

int[] Binary(int num)
{
    int num1 = num;
    int digits = 0; 
    while (num1 > 0)
    {
        num1 /= 2;
        digits += 1;
    }
    int[] bin = new int[digits];
    for (int i = 0; i < bin.Length; i++)
    {
        bin[i] = num%2;
        num /=2;
    }  
    Array.Reverse(bin);
    return bin;
}


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] binary = Binary(n);
PrintArray(binary);