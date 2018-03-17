using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double e;
            double a;
            double basic;

            Console.Write("Введите значение x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение точности e: ");
            e = double.Parse(Console.ReadLine());

            basic = Math.Pow(x, a);
            Console.WriteLine("Необходимое значение: " + basic.ToString());
            Console.WriteLine("Сумма ряда/значение k на котором достигается точность " + GetSum(x, a, e, basic).ToString());
        }

        // Метод для нахождения суммы
        public static Tuple<double, int> GetSum(double x, double a, double e, double basic)
        {
            double res = 0;
            int k = 0;

            while (Math.Abs(res - basic) > e)
            {
				// ---check--- и здесь такая же проблема, как в первом задании
                res = res + (Math.Pow(-1 + a, k) * x * Math.Pow(Math.Log(x), k))
                    / Factorial(k);
                k++;
            }
            return Tuple.Create(res, k - 1);
        }

        // Метод для нахождения факториалов
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
