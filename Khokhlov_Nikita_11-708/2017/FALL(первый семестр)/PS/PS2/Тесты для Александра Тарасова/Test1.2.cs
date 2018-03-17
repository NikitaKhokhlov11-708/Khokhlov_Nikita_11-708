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
            var result = ex.Program.SumFunction(2,0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GeneralTest()
        {
            var result = ex.Program.DetermineStep(0.5, 0.05);
            Assert.AreEqual(Tuple.Create(7, 0.484375), result);
        }

        [TestMethod]
        public void NullTest()
        {
            var result = ex.Program.DetermineStep(2, 0.05);
            Assert.AreEqual(null, result);
        }
    }
}