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
            var result = ex.Program.SumFunction(1);
            Assert.AreEqual(-0.11111111111111111, result);
        }

        [TestMethod]
        public void GeneralTest()
        {
            var result = ex.Program.DetermineStep(0.05);
            Assert.AreEqual(Tuple.Create(3, 3.15618147156995), result);
        }

        [TestMethod]
        public void NullTest()
        {
            var result = ex.Program.DetermineStep(0.0000000000000001);
            Assert.AreEqual(null, result);
        }
    }
}