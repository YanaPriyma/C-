// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
Console.WriteLine("Введите натуральное число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B:");
int b = Convert.ToInt32(Console.ReadLine());

int Degree (int x, int y)
{
    int res = 1;
    for (int i = 1; i <= y; i++)
    {
        res *= x;
    }
    return res;
}

int degree = Degree(a, b);
Console.WriteLine($"{a}, {b} -> {degree}");
