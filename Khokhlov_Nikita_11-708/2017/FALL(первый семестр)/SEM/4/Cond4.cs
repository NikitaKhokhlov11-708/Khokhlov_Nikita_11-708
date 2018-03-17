using System;


class Cond4
{
    public static void Main(string[] args)
    {
        double a;
        double b;
        double c;
        double d;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("[" + a + "," + b + "]");
        c = double.Parse(Console.ReadLine());
        d = double.Parse(Console.ReadLine());
        Console.WriteLine("[" + c + "," + d + "]");

        Console.WriteLine("Answer: " + GetIntersection(a, b, c, d));
    }

    public static string GetIntersection(double a, double b, double c, double d)
    {
        return "[" + Math.Max(a, c) + "," + Math.Min(b, d) + "]";
    }
}