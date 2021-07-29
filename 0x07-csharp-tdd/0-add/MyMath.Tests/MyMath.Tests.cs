using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void Add()
        {
            Assert.AreEqual(MyMath.Operations.Add(1, 2), 3);
            Assert.AreEqual(MyMath.Operations.Add(0, 0), 0);
        }

        [Test]
        public void AddNegativePositive()
        {
            Assert.AreEqual(MyMath.Operations.Add(-1, 2), 1);
            Assert.AreEqual(MyMath.Operations.Add(4, -8), -4);
        }

        [Test]
        public void AddNegative()
        {
            Assert.AreEqual(MyMath.Operations.Add(-4, -4), -8);
            Assert.AreEqual(MyMath.Operations.Add(-33, -1), -34);
        }
    }
}
