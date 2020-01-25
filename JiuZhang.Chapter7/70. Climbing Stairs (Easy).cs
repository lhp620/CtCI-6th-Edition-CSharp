using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    class _70
    {
        //https://leetcode.com/problems/climbing-stairs/description/
        public int climbStairs(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            int pre2 = 1, pre1 = 2;
            for (int i = 2; i < n; i++)
            {
                int cur = pre1 + pre2;
                pre2 = pre1;
                pre1 = cur;
            }
            return pre1;
        }
    }
}
