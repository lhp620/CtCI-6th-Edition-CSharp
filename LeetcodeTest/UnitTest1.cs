using System;
using LeetCode_Practices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string A = "this apple is sweet";
            string B = "this apple is sour";

            var question = new Uncommon_Words_from_Two_Sentences();
            var result = question.UncommonFromSentences(A, B);

            string[] expected = new string[2];
            expected[0] = "sweet";
            expected[1] = "sour";

            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] A = { 1, 1 };
            int[] B = { 2, 2 };
            
            var question = new _888();
            var result = question.FairCandySwap(A, B);

            int[] expected = new int[] { 1,2};

            Assert.IsTrue(result == expected);
        }
    }
}
