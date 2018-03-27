using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /* 
            4. Дана последовательность положительных целых
            чисел.Обрабатывая только нечетные числа, получить после-
            довательность их строковых представлений и отсортировать
            ее в лексикографическом порядке по возрастанию.
        */
        static void Main(string[] args)
        {
            List<int> input = ReadNumbers();
            IEnumerable<string> list = GetOddNumbers(input);
            WriteNumbers(ConvertAndSort(list));
        }

        public static IEnumerable<string> GetOddNumbers(List<int> list)
        {
            return list
                .Where(l => l%2==1)
                .Select(l => l.ToString());
        }

        public static List<int> ReadNumbers()
        {
            Console.WriteLine("Write 5 numbers:");
            List<int> input = new List<int>();
            for (int i=0;i < 5; i++)
            {
                input.Add(int.Parse(Console.ReadLine()));
            }
            return input;
        }

        public static List<string> ConvertAndSort(IEnumerable<string> input)
        {
            List<string> list = input.ToList();
            list.Sort();
            return list;
        }

        public static void WriteNumbers(List<string> list)
        {
            Console.WriteLine("Sorted:");
            foreach (string element in list)
                Console.WriteLine(element);
        }
    }
}
