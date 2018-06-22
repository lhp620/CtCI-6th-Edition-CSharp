using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JiuZhang.Chapter3;
using System.Collections.Generic;

namespace JiuZhang.Test
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Windows_Sum_test()
        {
            var array = new int[] { 1, 2, 3, 3 };
            var k = 2;

            int[] actual = Windows_Sum.WindowsSum(array, k);
            int[] expected = new int[3] { 3, 5, 6 };
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

        [TestMethod]
        public void Move_Zero_test()
        {
            var array = new int[] { 1, 0, 3, 3 };

            int[] actual = Move_Zeroes.MoveZeroes(array);
            int[] expected = new int[4] { 1, 3, 3, 0 };
            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }

        }

        [TestMethod]
        public void Valid_Palindrome_test()
        {
            var s = "A man, a plan, a canal: Panama";

            bool result = Valid_Palindrome.ValidPalindrome(s);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Three_Sum_test()
        {
            var s = new int[] { -1, 0, 1, 2 };

            var result = Three_Sum.ThreeSum(s);
            var expected = new List<List<int>>() { new List<int> { -1, 0, 1 } };

            for (int i = 0; i < expected.Count; i++)
            {
                for(int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(result[0][j], expected[i][j]);
                }
            }
        }

        [TestMethod]
        public void Triangle_Count_test()
        {
            var s = new int[] { 6, 1, 2, 2 };
            var s1 = new int[] { 10, 21, 22, 100, 101, 200, 300 };

            var result = Triangle_Count.TriangleCount(s);
            var result1 = Triangle_Count.TriangleCount(s1);

            Assert.AreEqual(result, 1);
            Assert.AreEqual(result1, 6);
        }

        [TestMethod]
        public void Two_Sum_Less_Than_or_Equal_To_Target_test()
        {
            var s = new int[] { 0, 1, 2, 3 };
            var target = 10;

            var result = Two_Sum_Less_Than_or_Equal_To_Target.TwoSumLessThanorEqualToTarget(s, target);

            Assert.AreEqual(result, 6);
        }
    }
}
