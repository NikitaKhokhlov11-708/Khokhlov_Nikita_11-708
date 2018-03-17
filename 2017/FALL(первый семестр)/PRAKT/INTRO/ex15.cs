using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(PrintGreeting("Student", 10.01));
            Console.WriteLine(PrintGreeting("Bill Gates", 10000000.5));
            Console.WriteLine(PrintGreeting("Steve Jobs", 1));
        }

        private static string PrintGreeting(string name, double salary)
        {
            return("Hello, "+name+", your salary is "+Math.Ceiling(salary));// возвращает "Hello, <name>, your salary is <salary>"
        }       
    }
}
