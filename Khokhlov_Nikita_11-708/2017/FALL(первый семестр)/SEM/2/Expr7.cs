using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Expr7
    {
        static void Main(string[] args)
        {
        	int a, b, c, xv, yv; // через уравнение прямой

          	a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            xv = (-1) * b;
            yv = a;
            Console.WriteLine("Параллельный вектор (" + x + "," + y + ")");
            Console.WriteLine();

            xv = a;
            yv = b;
            Console.WriteLine("Перп. вектор (" + x + "," + y + ")");
        }
    }
}