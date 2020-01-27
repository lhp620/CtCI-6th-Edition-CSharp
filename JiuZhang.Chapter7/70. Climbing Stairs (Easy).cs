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

        // https://leetcode.com/problems/climbing-stairs/discuss/25315/My-DP-solution-in-C%2B%2B-with-explanation
        public int ClimbStairs(int n)
        {
            int[] steps = new int[n];
            steps[0] = 1;
            steps[1] = 2;

            for (int i = 2; i < n; i++)
            {
                steps[i] = steps[i - 2] + steps[i - 1];
            }

            return steps[n - 1];
        }

    }
}
