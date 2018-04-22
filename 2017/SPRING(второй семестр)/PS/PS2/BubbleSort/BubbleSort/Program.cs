using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Считывание массива с файла
            int[] input = Array.ConvertAll(File.ReadAllText("10000.txt").Split(), int.Parse);
            int temp = 0;

            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();

            // Сортировка BubbleSort
            for (int write = 0; write < input.Length; write++)
            {
                for (int sort = 0; sort < input.Length - 1; sort++)
                {
                    if (input[sort] > input[sort + 1])
                    {
                        temp = input[sort + 1];
                        input[sort + 1] = input[sort];
                        input[sort] = temp;
                    }
                }
            }
            myStopwatch.Stop();

            // Запись массива в файл
            Console.WriteLine(myStopwatch.ElapsedMilliseconds.ToString());
            File.WriteAllText("res.txt", string.Join(" ", input));
        }
    }
}
