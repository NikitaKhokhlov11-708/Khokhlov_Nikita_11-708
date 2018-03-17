using System;
class Program
{

    /* «Хитрым способом» возвести в квадрат натуральное число, кратное 5 (число <10^9). 
        Способ: отбрасываем последнюю цифру, вычисляем произведение получившегося числа и числа на 1 больше,
        умножаем результат на 100 и добавляем к результату 25 (125^2 = 12 * 13 *100 +25). */
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Квадрат числа равен " + Squaring(num));
    }

    public static int Squaring(int num)
    {
        int res;

        if (num % 5 != 0) return -1;
        res = num / 10 * (num / 10 + 1) * 100 + 25;

        return res;
    }
}