using LeetCode.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests
{
    [TestClass]
    public class ReverseIntegerTest
    {
        [TestMethod]
        public void Reverse_Basic()
        {
            var srv = new ReverseInteger();

            int r = srv.Reverse(123);

            Assert.AreEqual(321, r);
        }

        [TestMethod]
        public void Reverse_Under_0()
        {
            var srv = new ReverseInteger();

            int r = srv.Reverse(-123);

            Assert.AreEqual(-321, r);
        }

        [TestMethod]
        public void Reverse_Overflow_Return_0()
        {
            var srv = new ReverseInteger();

            int r = srv.Reverse(int.MaxValue);

            Assert.AreEqual(0, r);
        }
    }
}
