using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA
{
    // Класс сосстояния
    public class State
    {
        public int ID { get; set; } = -1; // Порядковый номер состояния
        public Dictionary<char, State> Transitions { get; set; } = new Dictionary<char, State>(); // Словарь переходов между состояниями под действием символа
        public bool IsAcceptState { get; set; } = false;// Является ли состояние допускающим

        public State(int id)
        {
            ID = id;
        }

        // Метод добавления функции перехода к следующему состоянию
        public void AddTransition(char a, State s)
        {
            Transitions.Add(a, s);
        }
    }
}
