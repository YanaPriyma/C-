// по заданному номеру четверти выдвет диапазон возможных данных

Console.WriteLine("Укажите номер четверти");
string quarter = Convert.ToInt32(Console.ReadLine());


string Range (string xc)
{
    if (xc == "1") return "x > 0, y > 0";
    if (xc == "2") return "x < 0, y > 0";
    if (xc == "3") return "x < 0, y < 0";
    if (xc == "4") return "x > 0, y < 0";
    return "недопустимая четверть";
}
string range = Range(quarter);
Console.WriteLine(range);

