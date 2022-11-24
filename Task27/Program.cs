// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число:");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int SumDigits (int x)
{
    int sum = 0;
    while (x > 0) 
    {
        sum = sum + x % 10;
        x = x / 10;
    }
    return sum;
}

int sumDigits = SumDigits(a);
Console.WriteLine($"{a} -> {sumDigits}");