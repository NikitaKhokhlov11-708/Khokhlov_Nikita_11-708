using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FSA.Tests
{
    [TestClass]
    public class AutomataTests
    {
        Automata fsa = new Automata();

        State state = new State(0);

        [TestMethod]
        public void TestAddState()
        {
            fsa.AddState(0);
            fsa.AddState(1);
            fsa.AddState(2);
            Assert.AreEqual(1, fsa.ReturnStateByID(1).ID);
        }

        [TestMethod]
        public void TestAddTransition()
        {
            state.AddTransition('a', state);
            Assert.AreEqual(state, state.Transitions['a']);
        }
        [TestMethod]
        public void TestGeneratingWords()
        {
            char[] al = new char[3] { 'a', 'b', 'c' };
            List<string> words = new List<string>();
            words.AddRange(fsa.GetAllCombinations(al, 1).Select(list => string.Join("", list)).ToList());
            Assert.AreEqual("a", words[0]);
        }

        [TestMethod]
        public void TestRun()
        {
            fsa.AddState(0);
            Assert.AreEqual(false, fsa.Run("a".ToCharArray()));
        }
    }
}
