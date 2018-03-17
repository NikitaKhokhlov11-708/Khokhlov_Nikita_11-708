using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solver.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactorial()
        {
            var result = ex.Program.Factorial(4);
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void FactorialZero()
        {
            var result = ex.Program.Factorial(0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GeneralTest()
        {
            var result = ex.Program.DetermineStep(3,0.5);
            Assert.AreEqual(Tuple.Create(8, 22.173679235214216), result);
        }

        [TestMethod]
        public void SumAlgorithmTest()
        {
            var result = ex.Program.SumFunction(2,0);
            Assert.AreEqual(1, result);
        }
    }
}