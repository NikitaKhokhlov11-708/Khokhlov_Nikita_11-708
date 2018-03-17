using System;
class Program
{

    /* Вычислить НОК нескольких натуральных чисел <10^9. Количество чисел <10000. */
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int n = LeastMultiple(a, b);

        // Считывание нового числа и нахождение НОК для него и НОК предыдущих. Чтобы остановить ввод, необходимо ввести 0
        while (true)
        {
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Программа остановлена. НОК = " + n);
                break;
            }
            n = LeastMultiple(a, n);
        }
    }

    // Нахождение НОК для двух заданных чисел
    public static int LeastMultiple(int a, int b)
    {
        int res = Math.Max(a, b);

        while (true)
        {
            if (res % a == 0 && res % b == 0) break;
            else res++;
        }

        return res;
    }
}