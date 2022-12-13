// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int n1, int n2)
{
    if (n1 > n2)
    {
        return n2 + SumNumbers(n1, n2 + 1);
    }
    if (n1 < n2)
    {
        return n1 + SumNumbers(n1 + 1, n2);
    }
    return n1;
}

Console.WriteLine(SumNumbers(m, n));
