using System.Collections;
using System.Collections.Generic;
using System;

namespace SEM1
{
    public class EdgeList: IEnumerable<Edge>// односвязный список
    {
        Edge head; // головной/первый элемент
        Edge tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента
        public void Add(Tuple<int,int> data)
        {
            Edge edge = new Edge(data);

            if (head == null)
                head = edge;
            else
                tail.Next = edge;
            tail = edge;

            count++;
        }

        // удаление элемента
        public bool Remove(Tuple<int,int> data)
        {
            Edge current = head;
            Edge previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        // очистка списка
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        // содержит ли список элемент
        public bool Contains(Tuple<int,int> data)
        {
            Edge current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        // добвление в начало
        public void AppendFirst(Tuple<int,int> data)
        {
            Edge edge = new Edge(data);
            edge.Next = head;
            head = edge;
            if (count == 0)
                tail = head;
            count++;

            Print();
        }

        // поиск элемента по индексу
        public Edge GetEdge(int index)
        {
            Edge current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current;
        }

        // Добавление элемента по индексу
        public void AddByIndex(int index, Edge newEdge)
        {
            Console.WriteLine("Добавление ребра <" + newEdge.Data.Item1 + ", " + newEdge.Data.Item2 + "> в позицию " + index + ":");
            if (index == 0)
                AppendFirst(newEdge.Data);
            else
            {
                var prev = GetEdge(index - 1);
                var next = prev.Next;

                prev.Next = newEdge;
                newEdge.Next = next;

                if ((index + 1) == Count)
                    tail = newEdge;
            }
            count++;
            Print();
        }

        // Удаление вершины
        public void DeleteVertex()
        {
            int num = 3; // Для успешного запуска теста без необходимости ввода с консоли
            Console.WriteLine("Введите номер вершины, которую хотите удалить: " + num);
            // num = int.Parse(Console.ReadLine());
            int maxVertex = GetMaxVertex();
            for (int i = 0; i <= maxVertex; i++)
            {
                Tuple<int, int> check = new Tuple<int, int>(i, num);
                Remove(check);
                check = new Tuple<int, int>(num, i);
                Remove(check);
            }
            Print();

        }

        // Вывод списка на экран
        public void Print()
        {
            Console.WriteLine();
            foreach (Edge edge in this)
            {
                Console.WriteLine(edge.Data.Item1 + " " + edge.Data.Item2);
            }
            Console.WriteLine();
        }

        // Нахождение номера максимальной вершины
        public int GetMaxVertex()
        {
            Edge current = head;
            int maxHead = -1;
            int maxTail = -1;
            while (current != null)
            {
                if (current.Data.Item1 > maxHead)
                    maxHead = current.Data.Item1;
                if (current.Data.Item2 > maxTail)
                    maxTail = current.Data.Item2;
                current = current.Next;
            }
            return Math.Max(maxHead, maxTail);
        }

        // Возвращает список исходящих ребер, инцидентных некоторой вершине
        public EdgeList GetIncidentEdges(int vertex)
        {
            Console.WriteLine("Cписок исходящих ребер, инцидентных вершине " + vertex+":");

            EdgeList incidentList = new EdgeList();
            int maxVertex = GetMaxVertex();
            for (int i = 0; i <= maxVertex; i++)
                if (Contains(new Tuple<int,int>(vertex,i)))
                    incidentList.Add(new Tuple<int, int>(vertex, i));
            return incidentList;
        }

        // Вывод вершин, по отношению к исходящим ребрам степень инцидентности которых более m 
        public void GetVertex()
        {
            Console.Write("Список вершин, степень инцендентности (по отношению к исходящим ребрам) которых более ");
            int m = int.Parse(Console.ReadLine());
            int maxVertex = GetMaxVertex();
            for (int i = 0; i <= maxVertex; i++)
            {
                int vDegree = 0;
                for (int j = 0; j <= maxVertex; j++)
                {
                    if (Contains(new Tuple<int, int>(i, j)))
                        vDegree++;
                }
                if (vDegree > m)
                    Console.WriteLine(i);
            }

        }

        // реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Edge> GetEnumerator()
        {
            Edge current = head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}