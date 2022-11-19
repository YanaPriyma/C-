// На вход принимает 2 координаты и находит расстояние между ними
Console.WriteLine("Введите координаты точки А ");
Console.WriteLine("xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
Console.WriteLine("xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("yb: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance( int XA, int YA, int XB, int YB)
{
    double XC = (XA - XB)*(XA - XB);
    double YC = (YA - YB)*(YA - YB);
    double res = Math.Sqrt(XC + YC);
    return res;
}

double result = Distance(xa, ya, xb, yb);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);