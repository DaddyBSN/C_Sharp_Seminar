// Программа проверяет пятизначное число на палиндрома
// Ввод числа; проверка на 5 знаков; проверяем на = каждый знак в отражении; вывод

Console.Write("Enter a five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 9999 || num > 99999)
{
    Console.WriteLine("it's not a five-digit number");
}

else
{
    int numsave = num;
    int revnum = 0;

    while (num > 0)
    {
       int dig = num % 10;
       revnum = revnum * 10 + dig;
       num = num / 10;
    }
    if (numsave == revnum)
       Console.WriteLine("This is a palidroma");
    else
        Console.WriteLine("This is not palidroma");
}