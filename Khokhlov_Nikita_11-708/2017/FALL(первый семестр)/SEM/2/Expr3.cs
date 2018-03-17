using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Expr3
    {
        static void Main(string[] args)
        {
            int h, m;

            h = int.Parse(Console.ReadLine());
            if (h < 12 && h >= 0)
            {
                m = h * 30;
                if (m > 180) m = 360 - m;
                Console.WriteLine(m.ToString());
            }
            else if (h == 12) m = 0;
            else Console.WriteLine("Error");
        }
    }
}