using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solver.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToIntArray()
        {
            var result = ex.Program.ToIntArray(123);
            Assert.AreEqual(new int[] { 1, 2, 3 }, result);
        }

        [TestMethod]
        public void GCDTest()
        {
            var a = ex.Program.ToIntArray(169);
            var b = ex.Program.ToIntArray(13);
            var result = ex.Program.GCD(a, b);
            Assert.AreEqual(new int[] { 1, 3 }, result);
        }

        [TestMethod]
        public void LCMTest()
        {
            var a = ex.Program.ToIntArray(169);
            var b = ex.Program.ToIntArray(14);
            var result = ex.Program.GCD(a, b);
            Assert.AreEqual(new int[] { 2, 3, 6, 6 }, result);
        }
    }
}