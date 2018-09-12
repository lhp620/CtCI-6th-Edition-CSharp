using System;
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
    }
}
