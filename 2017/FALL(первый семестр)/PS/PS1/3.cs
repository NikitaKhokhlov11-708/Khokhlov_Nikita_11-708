using System;
class MainClass
{

    /* Найти самую часто повторяющуюся цифру в k-ичной системе счисления (k от 2 до 5)
     десятичного натурального числа n (n<=10^9) */
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int sys = int.Parse(Console.ReadLine());
	// надо было сделать без строк
        string conv = ChangeSys(num, sys);
        
        Console.WriteLine("В системе счисления k = " +  sys + ": " + conv);
        Console.WriteLine("Самая часто повторяющаяся цифра: " + GetFrequent(conv).ToString());
    }

    // Метод, меняющий систему счисления с 10 на заданную, результат в обратном порядке
    public static string ChangeSys(int num, int sys)
    {
        int tmp;
        string str = "";

        while (num > 0)
        {
            tmp = num % sys;
            num = num / sys;
            str = str + tmp.ToString();
        }

        return Inverse(str);
    }

    // Записывает результат конвертирования в нормальном порядке
    public static string Inverse(string str)
    {
        string inverted = "";
        int tmp = str.Length - 1;
        for (int i = 0; i < str.Length; i++)
        {
            inverted = inverted + str.Substring(tmp, 1);
            tmp = tmp - 1;
        }

        return inverted;
    }

    // Метод поиска часто встречабщейся цифры
    public static int GetFrequent(string conv)
    {
        int res = -1;
        int prev = 0; // Предыдушее максимальное количество цифр

        while (true)
        {
            int tmp = 0;
            int dig = int.Parse(conv.Substring(0, 1));

            for (int i = 0; i < conv.Length; i++)
            {
                if (int.Parse(conv.Substring(i, 1)) == dig) tmp++;
            }

            if (tmp > prev)
            {
                prev = tmp;
                res = dig;
            }

            conv = conv.Replace(dig.ToString(), "");

            if (conv.Length == 0) break;
        }

        return res;
    }
}
