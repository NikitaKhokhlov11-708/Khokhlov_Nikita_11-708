using System;

namespace ex2
{
    class Program
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

            basic = Math.Atan(x);
            Console.WriteLine("Необходимое значение: " + basic.ToString());
             Console.WriteLine("Сумма ряда/значение k на котором достигается точность " + GetSum(x, e, basic));
        }

        // Метод для нахождения суммы
        public static Tuple<double, int> GetSum(double x, double e, double basic)
        {
            double res = 0;
            int k = 1;

            while (Math.Abs(res - basic) > e)
            {
				// ---check--- аналогично
                res = res + ((Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1))
                    / (2 * k + 1));
                k++;
            }
            return Tuple.Create(res, k - 1);
        }
    }
}
