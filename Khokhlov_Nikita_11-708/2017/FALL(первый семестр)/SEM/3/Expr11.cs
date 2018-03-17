using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	/* Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах. */
    class Expr11
    {
        static void Main(string[] args)
        {
            double a, h, m;
            
            h = int.Parse(Console.ReadLine());
            if (h>12) h -= 12;
            m = int.Parse(Console.ReadLine());
            a = Math.Abs(h * 30 - m * 6);
            Console.WriteLine(a.ToString());
        }
    }
}