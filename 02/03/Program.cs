Console.WriteLine("Enter x: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y: ");
int y = int.Parse(Console.ReadLine());

if (x>0)
    {
    if(y>0)
        Console.WriteLine("1 четверть");
    }
if (x<0 && y>0)
    Console.WriteLine("2 четверть");
if (x<0 && y<0)
    Console.WriteLine("3 четверть");
if (x>0 && y<0)
    Console.WriteLine("4 четверть");
    