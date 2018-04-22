using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Считывание массива с файла
            string[] input = File.ReadAllText("1000.txt").Split();
        
            // Добавление 0 в начало, если кол-во разрядов числе меньше максимального
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length < 6)
                    for (int j = 0; j < 6 - input[i].Length; j++)
                        input[i] = input[i].Insert(0, " ");
            }

            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            Sort(input);
            myStopwatch.Stop();

            Console.WriteLine(myStopwatch.ElapsedMilliseconds.ToString());
            File.WriteAllText("res.txt", string.Join("", input));
        }

 
        public static void Sort(string[] a)
        {
            string[] aux = new string[a.Length];
            Sort(a, aux, 0, a.Length - 1, 0);
        }

        // Основной метод сортировки RadixSort
        private static void Sort(string[] a, string[] aux, int lo, int hi, int d)
        {
            if (lo >= hi) return;

            var R = 256;
            var count = new int[R + 2];

            for (var i = lo; i <= hi; ++i)
            {
                count[charAt(a[i], d) + 2]++;
            }

            for (var r = 0; r < R + 1; ++r)
            {
                count[r + 1] += count[r];
            }

            for (var i = lo; i <= hi; ++i)
            {
                aux[count[charAt(a[i], d) + 1]++] = a[i];
            }

            for (var i = lo; i <= hi; ++i)
            {
                a[i] = aux[i - lo];
            }

            for (var r = 0; r < R + 1; ++r)
            {
                Sort(a, aux, lo + count[r], lo + count[r + 1] - 1, d + 1);
            }
        }

        private static int charAt(string a, int d)
        {
            if (a.Length <= d)
            {
                return -1;
            }
            return a[d];
        }
    }
}
