// На вход принимает число N на выходе целые числа от -N до N включительно
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
count = -N;
if(N >= 0)
{
while(count <= -N)
{
    Console.WriteLine(count);
    count++;
}
}

