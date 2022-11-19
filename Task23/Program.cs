// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число N:");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

string Cube(int num)
{
    int count = 1;
    string table = "";
    while (count <= num)
    {
        table = table + $"{count} | {count*count*count} \n";
        count++;
    }
    return table;
}

string cubeTable = Cube(N);
Console.WriteLine(cubeTable);
