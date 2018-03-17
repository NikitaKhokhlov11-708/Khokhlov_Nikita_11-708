using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 1.5;
            double f = 1.02797;
            double h;
            int n;

            Console.Write("Введите количество отрезков n = ");
            n = int.Parse(Console.ReadLine());

            h = (b - a) / n;
            Console.WriteLine("Точное значение интеграла = " + f);
            Console.WriteLine("Значение интеграла методом левых прямоугольников = " + LeftRectAngle(h, n));
            Console.WriteLine("Значение интеграла методом правых прямоугольников = " + RightRectAngle(h, n));
            Console.WriteLine("Значение интеграла методом трапеций = " + TrapezoidalMethod(h, n));
            Console.WriteLine("Значение интеграла методом Симпсона = " + SimpsonMethod(a, b, n));
            Console.WriteLine("Значение интеграла методом МонтеКарло = " + MonteCarloMethod(a, b, n));

        }

        // Нахождение значения функции под знаком интеграла
        public static double BasicFunction(double x)
        {
            return Math.Tan(Math.Pow(Math.Sin(2 * x), 2));
        }

        // Метод левых прямоугольников
        public static double LeftRectAngle(double h, double n)
        {
            double res = 0;

            for (int i = 0; i < n; i++)
                res = res + BasicFunction(h * i);

            return h * res;
        }
        
        // Метод правых прямоугольников
        public static double RightRectAngle(double h, double n)
        {
            double res = 0;

            for (int i = 1; i <= n; i++)
                res = res + BasicFunction(h * i);

            return h * res;
        }

        // Метод трапеций
        public static double TrapezoidalMethod(double h, double n)
        {
            double res = 0;

            for (int i = 0; i < n; i++)
                res = res + BasicFunction(h * i) + BasicFunction(h * (i + 1));

            return (h * res) / 2;
        }

        // Метод Симпсона
        public static double SimpsonMethod(double a, double b, double n)
        {
            double h = (b - a) / (2 * n);
            double firstSum = 0;
            double secondSum = 0;

			//---check--- почему два цикла?
            for (int i = 1; i < n; i++)
                firstSum = firstSum + BasicFunction(2 * h * i + a);

            for (int i = 1; i <= n; i++)
                secondSum = firstSum + BasicFunction(h * (2 * i - 1) + a);

            return h * (BasicFunction(a) + 2 * firstSum + 4 * secondSum + BasicFunction(b)) / 3;
        }

        // Метод МонтеКарло
        public static double MonteCarloMethod(double a, double b, int n)
        {

            double u, sum = 0;
            double basis = (b - a) / n;

            for (int i = 1; i <= n; i++)
            {
                Random random = new Random();
                u = random.NextDouble() * (b - a) + a;
                sum += BasicFunction(u);

            }
            return (sum * basis);
        }

    }
}