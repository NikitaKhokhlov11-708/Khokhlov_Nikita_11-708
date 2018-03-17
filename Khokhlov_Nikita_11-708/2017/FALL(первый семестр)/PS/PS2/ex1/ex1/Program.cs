using System;

namespace ConsoleApp6
{
    class ex1
    {
        static void Main(string[] args)
        {
            double x;
            double e;
            double basic;

            Console.Write("Введите значение x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение точности e: ");
            e = double.Parse(Console.ReadLine());

            basic = Math.Sqrt(1 + x);
            Console.WriteLine("Необходимое значение: " + basic.ToString());
            Console.WriteLine("Сумма ряда/значение k на котором достигается точность " + GetSum(x, e, basic));
        }

        // Метод нахождения суммы 
        public static Tuple<double, int> GetSum(double x, double e, double basic)
        {
            double res = 0;
            int k = 0;

            while (Math.Abs(res - basic) > e)
            {
				// ---check--- неоптимально считаете, можно было домножать на соответствующие значения, а не с нуля степени считать
                res = res + ((Math.Pow(-1, k) * Factorial(2 * k) * Math.Pow(x, k))
                    / ((1 - 2 * k) * Math.Pow(Factorial(k), 2) * Math.Pow(4, k)));
                k++;
            }
            return Tuple.Create(res, k - 1);
        }

        // Метод для нахождения факториала
        public static int Factorial(int i)
        {
            int result;

            if (i == 1 || i == 0)
                return 1;
            result = Factorial(i - 1) * i;
            return result;
        }
    }
}
