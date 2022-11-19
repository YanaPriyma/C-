// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите пятизначное число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int Second(int n)
{
    while (n >= 100) n = n / 10;
    int second = n % 10;
    return second;       
}

int digit2 = Second(num);

bool Polindrome(int n, int m)
{
    if (((n / 10000) == (n % 10)) & (m ==  ((n % 100 - n % 10)/10))) return true;
    else return false;  
}

if (num.ToString().Length == 5)
{
    bool result = Polindrome(num, digit2);
    Console.WriteLine(result ? $"{num} --> да" : $"{num} --> нет");
}
else Console.WriteLine("Неверное число. Введите число длиной в 5 знаков");

