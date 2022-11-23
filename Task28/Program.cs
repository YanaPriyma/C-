// принимает число и выдает произведение от 1 до N
Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int MultDigits(int num)
{
    int mult = 0; 
    for (int i = 1; i <= num; i++)
    {
        mult = mult + i;
    } 
    return mult;
}

if (number > 0)
{
    int multDigits = MultDigits(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {multDigits}");
}
else 
    Console.WriteLine("Требуется ввести натуральное число");