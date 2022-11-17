// выводит случайное трехзначное число и удаляет вторую цифру 

int number = new Random().Next(100, 1000);
Console.WriteLine($"Рандобное число --> {number}");

int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int result = firstDigit*10 + lastDigit;
    return result;
}

int res = RemoveSecondDigit(number);
Console.WriteLine($"Искомое число --> {res}");