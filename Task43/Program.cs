// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

void Point(double a1, double c1, double a2, double c2)
{
    if (a1==a2 && c1==c2) Console.WriteLine ($"прямые совпадают");
    else if (c1==c2) Console.WriteLine ($"параллельные прямые");
    else
    {
        double x = (a2 - a1) / (c1 - c2);
        double y = c2 * x + a2;
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
        Console.WriteLine ($" -> ({x}; {y})");
    }
}

Point(b1, k1, b2, k2);

