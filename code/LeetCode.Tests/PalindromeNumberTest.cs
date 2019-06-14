using LeetCode.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LeetCode.Tests
{
    [TestClass]
    public class PalindromeNumberTest
    {
        [TestMethod]
        public void IsPalindrome_0_True()
        {
            var srv = new PalindromeNumber();

            bool isPalindrome = srv.IsPalindrome(0);

            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void IsPalindrome_1_True()
        {
            var srv = new PalindromeNumber();

            bool isPalindrome = srv.IsPalindrome(1);

            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void IsPalindrome_123_False()
        {
            var srv = new PalindromeNumber();

            bool isPalindrome = srv.IsPalindrome(123);

            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void IsPalindrome_11_True()
        {
            var srv = new PalindromeNumber();

            bool isPalindrome = srv.IsPalindrome(11);

            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void IsPalindrome_121_True()
        {
            var srv = new PalindromeNumber();

            bool isPalindrome = srv.IsPalindrome(121);

            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void IsPalindrome_1221_True()
        {
            var srv = new PalindromeNumber();

            bool isPalindrome = srv.IsPalindrome(1221);

            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void IsPalindrome_12321_True()
        {
            var srv = new PalindromeNumber();

            bool isPalindrome = srv.IsPalindrome(12321);

            Assert.IsTrue(isPalindrome);
        }
    }
}
