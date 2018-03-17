using System;

class Cond7
{
    public static void Main(string[] args)
    {
        double x;
        double y;
        int n;

        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());

        Console.WriteLine((int)CountVotes(x, y, n));
    }

    public static double CountVotes(double x, double y, int n)
    {
        return (x * n - y * n) / (y - 1);
    }
}