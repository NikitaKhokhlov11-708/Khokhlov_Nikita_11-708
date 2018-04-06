using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ReadNumbers();
            Console.WriteLine("Максимальная сумма подряд идущих элементов: " + GetMaxSum(list, 0, list.Count - 1));
        }

        static List<int> ReadNumbers()
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int value = rnd.Next(-100, 100);
                list.Add(value);
                Console.WriteLine(value);
            }
            return list;
        }

        static int GetMaxSum (List<int> list, int l, int r)
        {
            if (l == r)
                return Math.Max(list[l], -999999);
            int m = (l + r) / 2;
            int lmax = -999999;
            int sum = 0;

            for (int i = m; i >= l; i--)
            {
                sum += list[i];
                lmax = Math.Max(lmax, sum);
            }

            int rmax = -999999;
            sum = 0;
            for (int i = m + 1; i < r; i++)
            {
                sum += list[i];
                rmax = Math.Max(rmax, sum);
            }
            return Math.Max(Math.Max(lmax + rmax, GetMaxSum(list, l, m)), GetMaxSum(list, m + 1, r));
        }
    }
}
