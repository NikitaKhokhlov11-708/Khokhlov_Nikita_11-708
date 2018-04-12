using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /*
     * Даны строковые последовательности A и B, все строки в каждой из них имеют ненулевую длину. 
     * Сформировать последовательностей строк вида «a.b», где а – строка из А, b – 
     * либо строка из B с совпадающим количеством букв "q", 
     * что и в строке a, либо строка из одного символа “!”. 
     * Расположить элементы получившейся последовательности в лексикографическом порядке по убыванию.
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string> {
            "adasdfwqqeq",
            "safe34wsf",
            "dswrqsffsa214w"};

            List<string> b = new List<string> {
            "adasdfwqqeq",
            "safe34wsf",
            "dswrqsffsa214w"};

            foreach (string element in Task1(a, b))
                Console.WriteLine(element);
        }

        // Метод составления пар
        static List<string> Task1(List<string> a, List<string> b)
        {
            return a.Select(q => q + "." + (b.Select(x => ((CountQ(x) == 9)?x:"!")))).OrderByDescending(w => w).ToList();
        }

        // Поиск количества вхождений символа q в строку s
        static int CountQ(string s)
        {
            int count = s.Length - s.Replace("q", "").Length;
            return count;
        }
    }
}
