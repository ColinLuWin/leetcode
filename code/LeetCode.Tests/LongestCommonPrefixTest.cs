using System;
using LeetCode.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests
{
    [TestClass]
    public class LongestCommonPrefixTest
    {
        [TestMethod]
        public void GetLongestCommonPrefix_flower_flow_flight()
        {
            var srv = new LongestCommonPrefix();
            string s = srv.GetLongestCommonPrefix(new string[] { "flower", "flow", "flight" });

            Assert.AreEqual("fl", s);
        }

        [TestMethod]
        public void GetLongestCommonPrefix_dog_racecar_car()
        {
            var srv = new LongestCommonPrefix();
            string s = srv.GetLongestCommonPrefix(new string[] { "dog", "racecar", "car" });

            Assert.AreEqual("", s);
        }
    }
}
