// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int FindSecondDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int result = (num - firstDigit*100 - lastDigit)/10;
    return result;
}

Console.WriteLine(FindSecondDigit(number));