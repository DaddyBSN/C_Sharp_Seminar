// Возведите число А в натуральную степень B используя цикл
// Ввод число и степень, счетчик = степень ++, пока счетчик < степень

Console.WriteLine("Введи степень: ");
int math = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введи число: ");
int digit = int.Parse(Console.ReadLine() ?? "0");

int sum = math;
int i = 1;

while (i < digit)
{
    sum = sum + math;
    i++;
}

Console.WriteLine("Сумма чисел = " + sum);
