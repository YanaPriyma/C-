// задается два числа м и н . Программа должна вывести числа от м до н
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int n1, int n2)
{
    if (n1 > n2)
    {
        
        Console.Write($"{n2} ");
        NaturalNumbers(n1, n2 + 1);
    }
    if (n1 < n2)
    {
        Console.Write($"{n1} ");
        NaturalNumbers(n1+1, n2);
    }
    if (n1 == n2)
    {
        Console.Write($"{n1} ");
    }
}

NaturalNumbers(m, n);