// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CheckThirdDigit(int num)
{
    while (Math.Abs(num) >= 1000) num = num / 10;
    int res = num % 10;
    return Math.Abs(res);
}

if (Math.Abs(number) >= 100)
{
    Console.WriteLine(CheckThirdDigit(number));
}
else Console.WriteLine("третьей цифры нет");