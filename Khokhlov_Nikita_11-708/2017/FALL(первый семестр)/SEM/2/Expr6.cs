using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Expr6
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2, xp, yp;
            int a, b, c, p;
            int h;

            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            xp = int.Parse(Console.ReadLine());
            yp = int.Parse(Console.ReadLine());

            a = (int)Math.Sqrt(((x2 - x1) ^ 2) + ((y2 - y1) ^ 2));
            b = (int)Math.Sqrt((x2 - xp) ^ 2 + (y2 - yp) ^ 2);
            c = (int)Math.Sqrt((x1 - xp) ^ 2 + (y1 - yp) ^ 2);
            p = a + b + c;

            h = (int)((2/a) * Math.Sqrt(p * (p - a) * (p - b) * (p - c)));

            Console.WriteLine(h);
        }
    }
}
