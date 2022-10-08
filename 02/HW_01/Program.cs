// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// Ввод дня недели, проверка день недели или нет; 1-5 не выходной; 6-7 выходной

Console.WriteLine("Enter day number: ");
int day = int.Parse(Console.ReadLine() ?? "0");

if (day > 7 | day < 1) 
{
    Console.WriteLine("It's not a day of the week");
}

if (day == 6 | day == 7)
{
    Console.WriteLine("It's the weekend");
}

if (day >= 1 & day <= 5)
{
    Console.WriteLine("It's not the weekend");
}