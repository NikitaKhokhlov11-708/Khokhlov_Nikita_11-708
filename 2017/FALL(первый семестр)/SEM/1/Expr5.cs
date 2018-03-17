using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Expr5
    {
        public static void Main(string[] args)
        {
            int a, b, c;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = (b - a) / 4 - (b - a) / 100 + (b - a) / 400;
            Console.WriteLine(c);
        }
    }
}
