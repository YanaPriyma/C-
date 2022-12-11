// Задайте значение N. Выведите натуральные числа от 1 до N

Console.WriteLine("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num)
{
    if (num ==0) return;
    NaturalNumbers (num -1);
    Console.Write($"{num} ");
}

NaturalNumbers(number);

