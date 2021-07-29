using NUnit.Framework;

namespace TextTests
{
    public class PalindromeTests
    {
        [Test]
        public void Palindrome()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("racecar"));
            Assert.IsTrue(Text.Str.IsPalindrome("amma"));
            Assert.IsTrue(Text.Str.IsPalindrome("a"));
        }

        [Test]
        public void NotPalindrome()
        {
            Assert.IsFalse(Text.Str.IsPalindrome("racecars"));
            Assert.IsFalse(Text.Str.IsPalindrome("ammas"));
            Assert.IsFalse(Text.Str.IsPalindrome("ad"));
        }

        [Test]
        public void EmptyString()
        {
            Assert.IsTrue(Text.Str.IsPalindrome(""));
        }

        [Test]
        public void NullString()
        {
            Assert.IsFalse(Text.Str.IsPalindrome(null));
        }

        [Test]
        public void WhitespaceAndPucntString()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("a a"));
            Assert.IsFalse(Text.Str.IsPalindrome("a b"));
            Assert.IsTrue(Text.Str.IsPalindrome("a, b, a."));
            Assert.IsFalse(Text.Str.IsPalindrome("a, b, c."));
        }

        [Test]
        public void NonAlphanumericString()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("a1a"));
        }

        [Test]
        public void Capitals()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("Aa"));
            Assert.IsTrue(Text.Str.IsPalindrome("AaAa"));
        }
    }
}
