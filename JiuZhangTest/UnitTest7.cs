using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JiuZhang.Chapter7;

namespace JiuZhang.Test
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void String_Permutation_test()
        {
            var array = "ABC";
            String_Permutation.Permutate(array, 0, array.Length -1);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Dynamic_program_test()
        {
            int result_bottom_up = Dynamic_Programming.Bottom_Up_Cut_Rod(4);
            int result_recursive = Dynamic_Programming.Cut_Rod(4);
            int result_top_down = Dynamic_Programming.Memoized_Cut_Rod(4);

            Assert.AreEqual(result_bottom_up, 10);
            Assert.AreEqual(result_recursive, 10);
            Assert.AreEqual(result_top_down, 10);
        }

        [TestMethod]
        public void Find_Fewest_Coins_test()
        {
            int[] coins = new int[] { 3, 6, 8 };
            int summary = 9;
            int result = CSI_Interview_Questions.CoinsChanges_Dynamic(coins, coins.Length-1, summary);

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void Find_Triplets_test()
        {
            int[] arr = new int[] { -1, 0, 1, 2, -1, -4 };
            var result = CSI_Interview_Questions.FindTriplets(arr);
            List<int[]> output = new List<int[]>();
            output.Add(new int[] { -1, -1, 2 });
            output.Add(new int[] { -1, 0, 1 });

            Assert.AreEqual(result, output);
        }
    }
}
