using System;
using LeetCode.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests
{
    [TestClass]
    public class RomanToIntegerTest
    {
        [TestMethod]
        public void RomanToInt_III()
        {
            var srv = new RomanToInteger();

            int num = srv.RomanToInt("III");

            Assert.AreEqual(3, num);
        }

        [TestMethod]
        public void RomanToInt_IV()
        {
            var srv = new RomanToInteger();

            int num = srv.RomanToInt("IV");

            Assert.AreEqual(4, num);
        }

        [TestMethod]
        public void RomanToInt_IX()
        {
            var srv = new RomanToInteger();

            int num = srv.RomanToInt("IX");

            Assert.AreEqual(9, num);
        }

        [TestMethod]
        public void RomanToInt_LVIII()
        {
            var srv = new RomanToInteger();

            int num = srv.RomanToInt("LVIII");

            Assert.AreEqual(58, num);
        }

        [TestMethod]
        public void RomanToInt_MCMXCIV()
        {
            var srv = new RomanToInteger();

            int num = srv.RomanToInt("MCMXCIV");

            Assert.AreEqual(1994, num);
        }
    }
}
