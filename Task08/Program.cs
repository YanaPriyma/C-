// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("введите число: ");
int N  = Convert.ToInt32(Console.ReadLine());
int counter = 1;
while (counter <= N)
{
    if ( counter % 2 == 0)
    {
        Console.WriteLine(counter);
    }
    counter++;
}

