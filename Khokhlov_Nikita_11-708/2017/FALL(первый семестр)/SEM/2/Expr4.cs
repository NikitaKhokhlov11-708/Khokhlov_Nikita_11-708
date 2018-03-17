using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Expr4
    {
        static void Main(string[] args)
            {
                int n, x, y;

                n = int.Parse(Console.ReadLine());
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                n = n / x + n / y - n / (x * y) - 1;
                Console.WriteLine(n);
            }
    }
}