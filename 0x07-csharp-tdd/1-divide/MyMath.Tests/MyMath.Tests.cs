using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void Division()
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            Assert.AreEqual(MyMath.Matrix.Divide(matrix, 1), matrix);
        }

        [Test]
        public void DivisionByZero()
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            Assert.AreEqual(MyMath.Matrix.Divide(matrix, 0), null);
        }

        [Test]
        public void Matrix_isNull()
        {
            int[,] matrix = null;
            Assert.AreEqual(MyMath.Matrix.Divide(matrix, 1), null);
        }

        [Test]
        public void Matrix_isEmpty()
        {
            int[,] matrix = new int[,] { };
            Assert.AreEqual(MyMath.Matrix.Divide(matrix, 1), matrix);
        }

        [Test]
        public void Matrix_isZeros()
        {
            int[,] matrix = new int[,] { { 0, 0, 0 }, { 0, 0, 0 } };
            Assert.AreEqual(MyMath.Matrix.Divide(matrix, 1), matrix);
        }
    }
}
