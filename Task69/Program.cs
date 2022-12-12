// 2 числа, рекурсия возводит а в степень б
Console.WriteLine("Введите число a:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int numB = Convert.ToInt32(Console.ReadLine());

int DegreeNumber(int number, int degree)
{
    if (degree == 0) return 1;
    return DegreeNumber(number, degree - 1) * number;
}

Console.WriteLine(DegreeNumber(numA, numB));