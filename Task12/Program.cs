// принимает на вход 2 числа  и проверяет кратно ли первое число второму, 
// если не кратно -  выводит остаток от деления
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

bool Multiplicity (int number1, int number2)
{
    if (number1 % number2 == 0) return true;
    else return false;
}
bool result = Multiplicity(num1, num2);
Console.WriteLine(result ? "Кратно" : $"Некратно, остаток = {num1 % num2}");