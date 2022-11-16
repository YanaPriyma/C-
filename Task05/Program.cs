// На вход принимает число N на выходе целые числа от -N до N включительно
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = -number;
if(number >= 0)
{
while(count <= number)
{
    Console.Write(count+' ');
    count++;
}
}
else
{
    while (count >= number)
    {
        Console.Write(count+' ');
        count--
    }
}
