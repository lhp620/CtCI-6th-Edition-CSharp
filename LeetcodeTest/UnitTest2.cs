using System;
using System.Collections.Generic;
using LeetCode_Practices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] piles = {332484035, 524908576, 855865114, 632922376, 222257295, 690155293, 112677673, 679580077, 337406589, 290818316, 877337160, 901728858, 679284947, 688210097, 692137887, 718203285, 629455728, 941802184};
            int H = 823855818;

            var question = new _875();
            var result = question.MinEatingSpeed(piles, H);

            int expected = 4;

            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> x = new List<int>();
            x.Add(1);
            List<int> y = new List<int>();
            y.Add(1);
            Assert.IsTrue(x.Equals(y));

            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8 };

            var question = new _873();
            var result = question.LenLongestFibSubseq(A);

            int expected = 5;

            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] seats = { 1, 0, 0, 0};

            var question = new _849();
            var result = question.MaxDistToClosest(seats);

            int expected = 3;

            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string S = "ab#c";
            string T = "ad#c";

            var question = new _844();
            var result = question.BackspaceCompare(S, T);

            bool expected = true;

            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string S = "aaa";

            var question = new _830();
            var result = question.LargeGroupPositions(S);

            var expected = new List<List<int>>();
            expected[0] = new List<int> { 0, 2 };

            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string S = "loveleetcode";
            char C = 'e';

            var question = new _821();
            var result = question.ShortestToChar(S, C);

            int[] expected = {3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0};

            Assert.IsTrue(result == expected);
        }
    }
}
