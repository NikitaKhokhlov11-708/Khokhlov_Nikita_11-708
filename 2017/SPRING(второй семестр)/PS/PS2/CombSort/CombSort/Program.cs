using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Считывание массива с файла
            int[] input = Array.ConvertAll(File.ReadAllText("10000.txt").Split(), int.Parse);

            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            CombSort(ref input);
            myStopwatch.Stop();

            // Запись массива в файл
            Console.WriteLine(myStopwatch.ElapsedMilliseconds.ToString());
            File.WriteAllText("res.txt", string.Join(" ", input));
        }

        // Метод сортировки CombSort
        public static void CombSort(ref int[] data)
        {
            double gap = data.Length;
            bool swaps = true;

            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;

                if (gap < 1)
                    gap = 1;

                int i = 0;
                swaps = false;

                while (i + gap < data.Length)
                {
                    int igap = i + (int)gap;

                    if (data[i] > data[igap])
                    {
                        int temp = data[i];
                        data[i] = data[igap];
                        data[igap] = temp;
                        swaps = true;
                    }

                    ++i;
                }
            }
        }
    }
}
