// Задать номер четверти, показать диапазоны для возможных координат
// Ввод номера, если 1 то, если 2 то.... иначе такой нет

Console.WriteLine("Enter the number of the coordinate quarter");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("x > 0, y > 0");
}

else if (num == 2)
{
    Console.WriteLine("x < 0, y > 0");
}

else if (num == 3)
{
    Console.WriteLine("x < 0, y < 0");
}

else if (num == 4)
{
    Console.WriteLine("x > 0, y < 0");
}

else
{
    Console.WriteLine("There is no such coordinate quarter");
}
