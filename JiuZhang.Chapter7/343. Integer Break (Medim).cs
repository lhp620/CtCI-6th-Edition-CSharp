using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    class _343
    {
        //https://leetcode.com/problems/integer-break/description/
        public int integerBreak(int n)
        {
            int[] dp = new int[n + 1];
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    dp[i] = Math.Max(dp[i], Math.Max(j * dp[i - j], j * (i - j)));
                }
            }
            return dp[n];
        }
    }
}
