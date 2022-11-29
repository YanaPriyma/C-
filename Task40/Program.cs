// принимает 3 числа и проверяет существует ли треугольник с такими сторонами 
 
 
 bool Triangle(int a1, int b1, int c1)
 {
    return a1 < b1 + c1 || b1 < a1 + c1 || c1 < a1 + b1;

 }

Console.WriteLine("введите первую сторону треугольника: ");
int a = Convert.ToInt32(Console.Read());
Console.WriteLine("введите вторую сторону треугольника: ");
int b = Convert.ToInt32(Console.Read());
Console.WriteLine("введите третью сторону треугольника: ");
int c = Convert.ToInt32(Console.Read());

Console.WriteLine(Triangle(a,b,c) ? "треугольник может существовать" : "треугольник не может существовать");