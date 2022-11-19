// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А ");
Console.WriteLine("xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("za: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
Console.WriteLine("xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("yb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("zb: ");
int zb = Convert.ToInt32(Console.ReadLine());

double Distance (int X1,int Y1, int Z1, int X2, int Y2, int Z2 )
{
    double distance = Math.Sqrt(Math.Pow((X2-X1), 2) + Math.Pow((Y2-Y1), 2) + Math.Pow((Z2-Z1), 2));
    return distance;
}

double result = Math.Round(Distance(xa, ya, za, xb, yb, zb), 2);
Console.WriteLine(result);