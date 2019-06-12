using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Questions;

namespace LeetCode.Tests
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //act
            var srv = new TwoSum();
            var result = srv.Test(new int[] { 11, 2, 7, 11, 15 }, 9);

            //assert
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }
    }
}
