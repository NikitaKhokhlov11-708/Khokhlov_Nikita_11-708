using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA
{
    class Program
    {
        public static void Main(string[] args)
        {
            Automata fsa = new Automata();
            fsa.CreateAutomata();

            foreach(var word in fsa.GetAllWords())
                Console.WriteLine(word);
        }
    }
}
