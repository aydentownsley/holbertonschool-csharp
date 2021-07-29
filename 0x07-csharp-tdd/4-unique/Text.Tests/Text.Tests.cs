using NUnit.Framework;

namespace TextTests
{
    public class UniqueTests
    {

        [Test]
        public void UniqueChar()
        {
            Assert.AreEqual(Text.Str.UniqueChar("abc"), 0);
            Assert.AreEqual(Text.Str.UniqueChar("aabc"), 2);
            Assert.AreEqual(Text.Str.UniqueChar("aabbccd"), 6);
        }

        [Test]
        public void NoUniqueChar()
        {
            Assert.AreEqual(Text.Str.UniqueChar("aaa"), -1);
            Assert.AreEqual(Text.Str.UniqueChar("aaaaaaa"), -1);
            Assert.AreEqual(Text.Str.UniqueChar("aabbccdd"), -1);
        }
    }
}
