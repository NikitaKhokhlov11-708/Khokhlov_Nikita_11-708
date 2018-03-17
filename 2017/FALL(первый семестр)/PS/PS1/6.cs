using System;
class Program
{

    /* Найти значение произведения a*b*c таких чисел, что a^2+b^2=c^2 и a+b+c=1000 */
    public static void Main(string[] args)
    {
        GetProduct();
    }

    public static void GetProduct()
    {
        for (int a = 998; a > -1000; a--)
            for (int b = 998; b > -1000; b--)
                for (int c = 998; c > -1000; c--)
                    if (a * a + b * b == c * c && a + b + c == 1000 && a != 0 && b != 0 && c != 0)
                    {
                        Console.Write(a.ToString() + " * " + b.ToString() + " * " + c.ToString() + " = ");
                        Console.WriteLine((a * b * c).ToString());
                    }
    }
}