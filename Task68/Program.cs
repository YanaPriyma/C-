//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int Ackerman(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if ((a != 0) && (b == 0))
    {
        return Ackerman(a - 1, 1);
    }
    //Console.WriteLine($"A({a}, {b}) -> {Ackerman(a - 1, +Ackerman(a, b - 1))}");
    return Ackerman(a - 1, Ackerman(a, b - 1));
}

Console.WriteLine($"A({m}, {n}) = {Ackerman(m, n)}");