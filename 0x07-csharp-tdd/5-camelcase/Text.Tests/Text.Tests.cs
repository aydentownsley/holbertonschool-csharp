using NUnit.Framework;

namespace Text.Tests
{
    public class CamelTests
    {
        [Test]
        public void Standard()
        {
            Assert.AreEqual(Text.Str.CamelCase("a Bird Is Not A Dog"), 6);
            Assert.AreEqual(Text.Str.CamelCase("aCanaryCanSing"), 4);
        }

        [Test]
        public void NonStandard()
        {
            Assert.AreEqual(Text.Str.CamelCase("a-bird-is-not-a-dog"), 1);
            Assert.AreEqual(Text.Str.CamelCase(""), 0);
        }

        [Test]
        public void NullString()
        {
            Assert.AreEqual(Text.Str.CamelCase(null), 0);
        }
    }
}
