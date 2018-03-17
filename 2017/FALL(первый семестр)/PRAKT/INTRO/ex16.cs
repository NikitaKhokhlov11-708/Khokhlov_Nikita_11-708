using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ex16
    {
        public static void Main(string[] args)
        {
            Print(GetSquare(42));
        }

        private static int GetSquare(int a) {
            return a*a;
        }

        private static void Print (int a) {
            Console.WriteLine(a.ToString());
        }    
    }
}
