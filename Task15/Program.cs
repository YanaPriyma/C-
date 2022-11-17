// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());

bool Weekends(int num)
{
   return (num == 6 || num ==7);
}

if (  number <= 7 && number >= 1)
{
    Console.WriteLine(Weekends(number) ? "да" : "нет");
}
else Console.WriteLine("Число должно быть от 1 до 7 включиетельно. Повторите ввод.");