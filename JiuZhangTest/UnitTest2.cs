using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JiuZhang.Chapter4;

namespace JiuZhang.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Binary_Seach_odd_test()
        {
            var odd_array = new int[] { 1, 2, 3, 3, 4, 5, 10 };
            var target = 3;

            Assert.AreEqual(Binary_Search.BinarySearch(odd_array, target) , 2);
        }

        [TestMethod]
        public void Binary_Seach_even_test()
        {
            var odd_array = new int[] { 1, 2, 3, 3, 4, 5 };
            var target = 3;

            Assert.AreEqual(Binary_Search.BinarySearch(odd_array, target), 2);
        }

        [TestMethod]
        public void Binary_Seach_duplicate_test()
        {
            var odd_array = new int[] { 3, 3 };
            var target = 3;

            Assert.AreEqual(Binary_Search.BinarySearch(odd_array, target), 0);
        }

        [TestMethod]
        public void Find_K_Closest_test1()
        {
            var odd_array = new int[] { 1, 2, 3 };
            var target = 3;
            var k = 2;

            var actual = Find_K_Closest_Elements.kClosestNumbers(odd_array, target, k);
            var expect = new int[] { 3, 2 };
            for(int i = 0; i < k; i++)
            {
                Assert.AreEqual(actual[i], expect[i]);
            }
        }

        [TestMethod]
        public void Find_K_Closest_test2()
        {
            var odd_array = new int[] { 1, 4, 6, 8 };
            var target = 3;
            var k = 3;

            var actual = Find_K_Closest_Elements.kClosestNumbers(odd_array, target, k);
            var expect = new int[] { 4, 1, 6 };
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(actual[i], expect[i]);
            }
        }

        [TestMethod]
        public void Search_In_Rotated_test2()
        {
            var odd_array = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var target = 2;

            Assert.AreEqual(Search_In_Rotated_Sorted_Array.SearchInRotatedSortedArray(odd_array, target), 6);
        }
    }
}
