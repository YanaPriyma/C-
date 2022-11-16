// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine($"max =  {a}");   
}
else if (b > a && b > c)
{
    Console.WriteLine($"max =  {b}"); 
}
else
{
    Console.WriteLine($"max =  {c}"); 
}
