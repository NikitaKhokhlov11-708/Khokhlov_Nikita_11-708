using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ex11
    {
        public static void Main(string[] args)
        {
            string doubleNumber = "894376.243643";
            double number = double.Parse(doubleNumber); // Вася уверен, что ошибка где-то тут
            Console.WriteLine(number + 1);
        }
    }
}
