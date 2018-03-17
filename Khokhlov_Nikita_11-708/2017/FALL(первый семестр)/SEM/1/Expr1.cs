using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Expr1
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            //change(a, b);
            change2(a, b);
        }

        public static void change(int a, int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a.ToString() + " " + b.ToString());
        }

        public static void change2(int a, int b)
        {
            b = b - a;
            a = b + a;
            b = a - b;
            Console.WriteLine(a.ToString() + " " + b.ToString());
        }
    }
}