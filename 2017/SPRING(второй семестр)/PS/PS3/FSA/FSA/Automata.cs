using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA
{
    // Класс Дет. Конечного Автомата
    class Automata
    {
        public static List<State> states; // Список всех состояний. По умолчанию начальное состояние - 0
        public static int numOfStates = 0; // Количество состояний
        public static List<Tuple<int, int>> edges; // Список ребер между состояниями
        public static char[] alph; // Алфавит (массив символов алфавита)


        // Метод создания автомата с вводом параметров
        public void CreateAutomata()
        {
            Console.Write("Введите все символы алфавита: ");
            alph = Console.ReadLine().ToCharArray();

            Console.Write("Введите количество состояний: ");
            numOfStates = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfStates; i++)
            {
                states.Add(
                    new State
                    {
                        id = i
                    });
            }

            foreach (var state in states)
            {
                Console.Write("Является ли состояние " + state.id + " допускающим? ");
                switch (Console.ReadLine())
                {
                    case "Да":
                        state.isAcceptState = true;
                        break;

                    case "Нет":
                        state.isAcceptState = false;
                        break;
                }

                foreach (var letter in alph)
                {
                    Console.Write("Введите номер состояния, на который осуществляется переход под действием символа " + letter + ": ");
                    int nextState = int.Parse(Console.ReadLine());
                    state.transitions.Add(letter, states.Where(s => s.id == nextState).ToList()[0]);
                    if (nextState != state.id && !edges.Contains(new Tuple<int, int>(state.id, nextState)))
                        edges.Add(new Tuple<int, int>(state.id, nextState));
                }
            }
        }


        // Метод проверки, принимает ли автомат данное слово
        public bool Run(char[] s)
        {
            State current = states[0];
            foreach (var c in s)
            {
                if (current.transitions.ContainsKey(c))
                {
                    current = current.transitions[c];
                }
            }
            return current.isAcceptState;
        }

        // Метод нахождения длины минимального пути между начальным и конкретным конечным состоянием
        public int ShortestPath(List<Tuple<int, int>> edges, int lastState)
        {
            int[] d = new int[numOfStates];
            for (int i = 0; i < d.Length; i++)
                d[i] = -1;

            d[0] = 0;

            Queue<int> q = new Queue<int>();
            q.Enqueue(0);

            while (q.Count != 0)
            {
                int u = q.Dequeue();
                foreach (var el in edges)
                    if (el.Item1 == u)
                        if (d[el.Item2] == -1)
                        {
                            d[el.Item2] = d[el.Item1] + 1;
                            q.Enqueue(el.Item2);
                        }
            }

            return d[lastState];
        }

        // Метод нахождения длины кратчайшего пути(слова) между всеми допускающими состояниями
        public int ShortestWord()
        {
            List<int> minLength = new List<int>();
            List<State> finiteStates = states.Where(s => s.isAcceptState == true).ToList();
            foreach (var state in finiteStates)
                minLength.Add(ShortestPath(edges, state.id));

            return minLength.Min();
        }

        // Метод проверки сгенерированных слов на принимаемость автоматом (возвращает только прошедшие слова)
        public List<string> GetAllWords()
        {
            List<string> res = new List<string>();
            List<string> words = new List<string>();
            int minLength = ShortestWord();

            Console.Write("Введите количество слов, которые необходимо проверить: ");
            int numOfGeneratedWords = int.Parse(Console.ReadLine());

            while (words.Count < numOfGeneratedWords)
            {
                words.AddRange(GetAllCombinations(alph, minLength).Select(list => string.Join("", list)).ToList());
                minLength += 1;
            }

            foreach (var word in words)
                if (Run(word.ToCharArray()))
                    res.Add(word);

            return res;
        }

        // Метод генерации всех возможных слов длины *length* из всех символов алфавита
        public IEnumerable<IEnumerable<T>> GetAllCombinations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return GetAllCombinations(list, length - 1)
                .SelectMany(t => list, (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}
