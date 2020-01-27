using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JiuZhang.Chapter6;

namespace JiuZhang.Test
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void Combination_Sum_test()
        {
            var array = new int[] { 1, 2 };
            var k = 4;

            var actual = Combination_Sum.combinationSum(array, k);
            int[][] expected = new int[3][];
            expected[0] = new int[] { 1, 1, 1, 1 };
            expected[1] = new int[] { 1, 1, 2 };
            expected[2] = new int[] { 2, 2 };

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < expected[i].Count(); j++)
                {
                    Assert.AreEqual(actual[i][j], expected[i][j]);
                }
            }
        }

        [TestMethod]
        public void Word_Break_test()
        {
            var dict = new List<string> {"i", "love", "sky"};
            var s = "ilovesky";

            var actual = Word_Break.WordBreak_(s, dict);
            Assert.AreEqual(actual, true);
            actual = Word_Break.WordBreak_(s, dict);
            Assert.AreEqual(actual, true);

        }

        [TestMethod]
        public void Letter_Combination_Test()
        {
            string s = "23";
            var result = _17.letterCombinations(s);
            Assert.AreEqual(new List<string>(), result);
        }

        [TestMethod]
        public void Permutation_Test()
        {
            int[] nums = { 1, 2, 3};
            var result = Permutations.Permutations_(nums, 3);
            Assert.AreEqual(new List<string>(), result);
        }

    }
}
