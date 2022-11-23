// gпринимает число и выдает количество цифр в числе
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int NumLength(int num)
{
    int counter = 0;
    while (num > 0)
    {
        num = num / 10;
        counter ++;
    }
    return counter;
}

int numLength = NumLength(number);
Console.WriteLine($"{number} -> {numLength}");