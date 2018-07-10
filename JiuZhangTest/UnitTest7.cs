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
    }
}
