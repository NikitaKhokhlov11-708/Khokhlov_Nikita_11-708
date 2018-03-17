using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }

        static string GetLastHalf(string text)
        {
            int s = (text.Length / 2);
            string a =  text.Substring(s, s);
            a = a.Replace(" ","");
            return a;
        } 
    }
}
