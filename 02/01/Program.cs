Console.Write ("Enter a number");
int n = int.Parse(Console.ReadLine() ?? "0");
int first = n / 10;
int second = n % 10;
Console.WriteLine("First digit " + first);
Console.WriteLine("Second digit " + second);
if(first>second)
{
    Console.Write("The biggest digit: " + first);
}
else
{
    Console.WriteLine("The biggest digit: " + second);
}