using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    class _62
    {
        //https://leetcode.com/problems/unique-paths/description/
        public int uniquePaths(int m, int n)
        {
            int[] dp = new int[n];
            for(int i = 0; i < n;  i++)
            {
                dp[i] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[j] = dp[j] + dp[j - 1];
                }
            }
            return dp[n - 1];
        }
    }
}
