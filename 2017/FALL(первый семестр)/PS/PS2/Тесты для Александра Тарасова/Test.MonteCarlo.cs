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
            var result = ex.Program.MonteCarlo(1,4,5);
            Assert.AreEqual(0.28251937651340359, result);
        }
    }
}