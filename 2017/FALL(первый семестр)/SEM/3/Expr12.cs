using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	/* 1885. Комфорт пассажиров. http://acm.timus.ru/problem.aspx?num=1885 */
    class Expr12
    {
        static void Main(string[] args)
        {
            double h, t, v, x, tmin, tmax;
            
            h = int.Parse(Console.ReadLine());
            t = int.Parse(Console.ReadLine());
            v = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
			
			if (h/x <= t) {
 				tmin = 0;
 				tmax = h/x;
 			}
 			else {
 				tmin = (h-x*t)/(v - x);
            	tmax = t;
 			}

            Console.WriteLine(tmin.ToString()+" "+tmax);
        }
    }
}