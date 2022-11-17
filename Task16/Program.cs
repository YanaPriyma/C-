// на вход 2 числа и проверяется является ли одно квадратом другого
Console.WriteLine("Введите 2 числа на проверку:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

bool Square (int num1, int num2)
{
    return ((num1 == num2*num2) || (num2 == num1*num1));
}

Console.WriteLine(Square(number1, number2) ? "да" : "нет");