﻿// выводит случайное число из отрезка [10,99] п иказывает его наибольшую цифру  

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 1-99 --> {number}");


int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;

    // int max = firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");