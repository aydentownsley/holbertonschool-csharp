using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class MaxInt
    {
        [Test]
        public void FindMax()
        {
            List<int> list = new List<int>() {6, 20, 3, 4, 5 };
            Assert.AreEqual(MyMath.Operations.Max(list), 20);
            List<int> list2 = new List<int>() { 6, 20, 3, 4, 50, 1 };
            Assert.AreEqual(MyMath.Operations.Max(list2), 50);
        }

        [Test]
        public void FindMaxLast()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            Assert.AreEqual(MyMath.Operations.Max(list), 5);
        }

        [Test]
        public void FindMaxFirst()
        {
            List<int> list = new List<int>() { 5, 2, 3, 4, 1 };
            Assert.AreEqual(MyMath.Operations.Max(list), 5);
        }

        [Test]
        public void FindMaxMiddle()
        {
            List<int> list = new List<int>() { 1, 2, 5, 4, 3 };
            Assert.AreEqual(MyMath.Operations.Max(list), 5);
        }

        [Test]
        public void FindMaxEmpty()
        {
            List<int> list = new List<int>() { };
            Assert.AreEqual(MyMath.Operations.Max(list), 0);
        }

        [Test]
        public void FindMaxDuplicates()
        {
            List<int> list = new List<int>() {4, 4, 4, 4, 4};
            Assert.AreEqual(MyMath.Operations.Max(list), 4);
        }

        [Test]
        public void FindMaxNegative()
        {
            List<int> list = new List<int>() { -1, -2, -3, -4, -5 };
            Assert.AreEqual(MyMath.Operations.Max(list), -1);
        }
    }
}
