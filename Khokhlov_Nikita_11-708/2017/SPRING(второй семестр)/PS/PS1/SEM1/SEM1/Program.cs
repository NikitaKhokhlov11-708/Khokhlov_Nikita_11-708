using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SEM1
{
    public class Program
    {
        static void Main(string[] args)
        {
            EdgeList list = Code();
            list.AddByIndex(1, new Edge(new Tuple<int, int>(0, 0)));
            EdgeList incidentList = list.GetIncidentEdges(3);
            incidentList.Print();
            list.DeleteVertex();
            list.GetVertex();
            Decode(list);
        }

        // Метод считывания матрицы инцидентности из файла и записи ее в лист
        public static EdgeList Code()
        {
            Console.WriteLine("Считываем с файла...");

            EdgeList list = new EdgeList();

            string[] lines = System.IO.File.ReadAllLines("input.txt");
            int numOfVertex = lines.Length;
            int numOfEdges = lines[0].Split(' ').Length;
            int[,] arr = new int[numOfVertex, numOfEdges];


            for (int i = 0; i < numOfVertex; i++)
            {
                int[] row = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int j = 0; j < numOfEdges; j++)
                {
                    arr[i, j] = row[j];
                }
            }

            int headOfEdge = -1;
            int tailOfEdge = -1;
            for (int j = 0; j < numOfEdges; j++)
            {
                for (int i = 0; i < numOfVertex; i++)
                    switch (arr[i, j])
                    {
                        case 1:
                            headOfEdge = i;
                            break;

                        case -1:
                            tailOfEdge = i;
                            break;
                    }
                list.Add(new Tuple<int, int>(headOfEdge, tailOfEdge));
            }
            Console.WriteLine("Готово!");
            list.Print();
            return list;
        }

        // Метод записи листа в виде матрицы инцидентности в файл
        static void Decode(EdgeList list)
        {
            int[,] temp = new int[list.GetMaxVertex() + 1, list.Count()];
            for (int i = 0; i < temp.GetUpperBound(0); i++)
                for (int j = 0; j < temp.GetUpperBound(1); j++)
                    temp[i, j] = 0;

            int ind = 0;
            foreach(Edge edge in list) {
                temp[edge.Data.Item1, ind] = 1;
                temp[edge.Data.Item2, ind] = -1;
                ind++;
            }
            list.Clear();
            Console.WriteLine("Записываем в файл...");
            StreamWriter print = new StreamWriter("output.txt", false);         
            for (int i = 0; i <= temp.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= temp.GetUpperBound(1); j++)
                {
                    print.Write(temp[i, j] + " "); // запись в файл массива                
                }
                print.WriteLine();
            }
            print.Close();
            Console.WriteLine("Готово!");
        }
    }
}

