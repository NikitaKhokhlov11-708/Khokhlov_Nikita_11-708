using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Expr2
    {
        public static void Main(string[] args)
        {
            int a = 123;
            int b = a/100;
            
            //a = a%100;
            b += ((a%100)/10) * 10;
            b += ((a%100)%10) * 100; 
            Console.WriteLine(b);
        }
    }
}
