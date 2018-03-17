using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solver.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumAlgorithmTest()
        {
            var result = ex.Program.Function(1.5);
            Assert.AreEqual(-0.99936144244983, result);
        }

        [TestMethod]
        public void GeneralTest()
        {
            var result = ex.Program.Simpson(2, 4, 12);
            Assert.AreEqual(0.2711455559024431, result);
        }
    }
}