using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	/* Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5. */
    class Expr10
    {
        static void Main(string[] args)
        {
            int sum = 0;
           
            sum = 999/3*(3+999)/2 + 999/5*(5+995)/2 - 999/15*(15+990)/2;
            Console.WriteLine(sum.ToString());
        }
    }
}