using System;

namespace ConsoleApp4
{
    class Cond3
    {
        static void Main(string[] args)
        {
            String num;
            int tmp;

            num = Console.ReadLine();
            tmp = int.Parse(num);
            tmp += 1;
            Console.WriteLine("Next: " + CheckLucky(tmp.ToString()));
            tmp -= 2;
            Console.WriteLine("Previous: " + CheckLucky(tmp.ToString()));
        }

        public static bool CheckLucky(String num)
        {
            int tmp = int.Parse(num);
            int a = int.Parse(num.Substring(0, 1));
            int b = int.Parse(num.Substring(1, 1));
            int c = int.Parse(num.Substring(2, 1));
            int d = int.Parse(num.Substring(3, 1));
            int e = int.Parse(num.Substring(4, 1));
            int f = int.Parse(num.Substring(5, 1));
            if (a + b + c == d + e + f) return true;
            
            return false;
        }
    }
}
