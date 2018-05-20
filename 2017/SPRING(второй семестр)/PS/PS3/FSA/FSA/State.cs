using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA
{
    // Класс сосстояния
    class State
    {
        public int id; // Порядковый номер состояния
        public Dictionary<char, State> transitions; // Словарь переходов между состояниями под действием символа
        public bool isAcceptState; // Является ли состояние допускающим
    }
}
