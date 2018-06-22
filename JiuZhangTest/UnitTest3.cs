using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JiuZhang.Chapter3;

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
    }
}
