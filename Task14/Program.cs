// принимает на вход число и проверяет является ли кратным одновременно 7 и 23
Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

bool Multiplicity (int num)
{
    return (num % 7 == 0 && num % 23 == 0);
}

Console.WriteLine(Multiplicity(number) ? "Да" : "Нет");