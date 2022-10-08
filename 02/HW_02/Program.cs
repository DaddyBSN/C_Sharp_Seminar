// По двум заданным числам проверять является ли одно квадратом другого
// Ввод 2х чисел; если ч2*ч2 = ч1 да, иначе если ч1*ч1 = ч2 да, иначе нет

Console.WriteLine("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 == num2)
{
    Console.WriteLine("Yes, the second number is the square of the first");
}

else if(num2 * num2 == num1)
{
    Console.WriteLine("Yes, the first number is the square of the second");
}

else
{
    Console.WriteLine("No squares here >_<");
}