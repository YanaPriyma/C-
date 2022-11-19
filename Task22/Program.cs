// принимает на вход число N и выдает таблицу квадратов чисел от 1 до N
Console.WriteLine("Введите число N:");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

string Square(int num)
{
    int count = 1;
    string table = "";
    while (count <= num)
    {
        table = table + $"{count} --> {count*count} \n";
        count++;
    }
    return table;
}

string sqrTable = Square(N);
Console.WriteLine(sqrTable);
