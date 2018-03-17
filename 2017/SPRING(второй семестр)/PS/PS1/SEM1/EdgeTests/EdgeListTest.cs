using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEM1;

namespace EdgeTests
{
    [TestClass]
    public class EdgeListTest
    {
        [TestMethod]
        public void TestCode()
        {
            EdgeList list = new EdgeList();
            EdgeList real = Program.Code();
            list.Add(new Tuple<int, int>(0, 1));
            list.Add(new Tuple<int, int>(3, 0));
            list.Add(new Tuple<int, int>(1, 3));
            list.Add(new Tuple<int, int>(1, 2));
            list.Add(new Tuple<int, int>(3, 2));
            list.Add(new Tuple<int, int>(0, 3));
            Assert.AreEqual(list.Count, real.Count);
            Assert.AreEqual(list.GetEdge(0).Data.Item1, Program.Code().GetEdge(0).Data.Item1);
        }

        [TestMethod]
        public void TestAddByIndex()
        {
            EdgeList expected = new EdgeList();
            EdgeList real = Program.Code();
            real.AddByIndex(1, new Edge(new Tuple<int, int>(0, 0)));
            expected.Add(new Tuple<int, int>(0, 1));
            expected.Add(new Tuple<int, int>(0, 0));
            expected.Add(new Tuple<int, int>(3, 0));
            expected.Add(new Tuple<int, int>(1, 3));
            expected.Add(new Tuple<int, int>(1, 2));
            expected.Add(new Tuple<int, int>(3, 2));
            expected.Add(new Tuple<int, int>(0, 3));
            Assert.AreEqual(expected.Count, real.Count);
            Assert.AreEqual(expected.GetEdge(1).Data.Item1, real.GetEdge(1).Data.Item1);
        }

        [TestMethod]
        public void TestRemove()
        {
            EdgeList expected = new EdgeList();
            EdgeList real = Program.Code();
            real.Remove(new Tuple<int, int>(3, 0));
            expected.Add(new Tuple<int, int>(0, 1));
            expected.Add(new Tuple<int, int>(1, 3));
            expected.Add(new Tuple<int, int>(1, 2));
            expected.Add(new Tuple<int, int>(3, 2));
            expected.Add(new Tuple<int, int>(0, 3));
            Assert.AreEqual(expected.Count, real.Count);
            Assert.AreEqual(expected.Contains(new Tuple<int, int>(3, 0)), real.Contains(new Tuple<int, int>(3, 0)));
        }

        [TestMethod]
        public void TestGetIncidentEdges()
        {
            EdgeList expected = new EdgeList();
            EdgeList real = Program.Code().GetIncidentEdges(3);
            real.Remove(new Tuple<int, int>(3, 0));
            expected.Add(new Tuple<int, int>(3, 2));
            Assert.AreEqual(expected.Count, real.Count);
        }

        [TestMethod]
        public void TestDeleteVertex()
        {
            EdgeList expected = new EdgeList();
            EdgeList real = Program.Code();
            real.DeleteVertex();
            expected.Add(new Tuple<int, int>(0, 1));
            expected.Add(new Tuple<int, int>(1, 2));
        }
    }
}