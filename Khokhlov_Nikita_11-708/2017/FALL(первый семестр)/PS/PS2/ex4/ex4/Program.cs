using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double e;

            Console.Write("Введите значение точности e: ");
            e = double.Parse(Console.ReadLine());

            Console.WriteLine("Необходимое значение: " + Math.PI.ToString());
            Console.WriteLine("Сумма ряда равна: " + GetSum(e).ToString());
        }

        // Метод для нахождения суммы
        public static Tuple<double, int> GetSum(double e)
        {
            double sum = 0;
            int k = 1;

            while (Math.Abs(2 * sum - 2 - Math.PI) > e)
            {
				// ---check--- тоже неоптимальное решение
                sum = sum + (Math.Pow(2, k) * Factorial(k) * Factorial(k)) / Factorial(2 * k);
                k++;
            }

            return Tuple.Create(2 * sum - 2, k - 1);
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
