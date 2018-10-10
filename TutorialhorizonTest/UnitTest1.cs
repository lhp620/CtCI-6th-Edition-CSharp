using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tutorialhorizon_Practices;

namespace TutorialhorizonTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] value = { 2, 3, 7, 8, 9 };
            int len = 5;

            var question = new RodCuttingRecursion();
            var result = question.profit(value, len);

            int expected = 10;
            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] A = { 3, 2, 7, 1 };
            int[] solution = new int[A.Length];
            List<List<int>> answer = new List<List<int>>();

            var question = new Dynamic_Programming___Subset_Sum_Problem();
            question.find(A, 0, 0, 6, solution, answer);

            bool actual = false;
            if (answer.Count > 0)
            {
                actual = true;
            }

            bool expected = true;

            Assert.IsTrue(actual == expected);
        }
    }
}
