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
    }
}
