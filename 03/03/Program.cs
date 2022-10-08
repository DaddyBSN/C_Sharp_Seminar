// Возведите число А в натуральную степень B используя цикл
// Ввод число и степень, счетчик = степень ++, пока счетчик < степень

Console.WriteLine("Введи число: ");
int digit = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введи степень: ");
int math = int.Parse(Console.ReadLine() ?? "0");

int sum = digit;
int i = 1;

while (i < math)
{
    sum = sum * digit;
    i++;
}

Console.WriteLine(digit + " в степени " + math + " = " + sum);