//
//
Console.WriteLine("Enter number a: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter number b: ");
int b = int.Parse(Console.ReadLine() ?? "0");

int max = 0;
int min = 0;

if (a < b)
{
    min = a;
    max = b;
    Console.WriteLine("Min = " + min);
    Console.WriteLine("Max = " + max);
}
else
if (b < a)
{
    min = b;
    max = a;
    Console.WriteLine("Min = " + min);
    Console.WriteLine("Max = " + max);
}
else
{
    Console.WriteLine("Числа равны");
}
