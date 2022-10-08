// Найти расстояние между точками в пространстве 3D
// Ввод xyz A и xyz B; AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.WriteLine("Enter the coordinates A x");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates A y");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates A z");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinates B x");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates B y");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates B z");
double zB = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

Console.WriteLine("the distance is equal to: " +res);


