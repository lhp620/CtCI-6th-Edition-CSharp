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

        // https://leetcode.com/problems/unique-paths/discuss/22954/C%2B%2B-DP 
        public int uniquePaths2(int m, int n)
        {
            int[][] dp = new int[m][];
            for(int i = 0; i < m; m++)
            {
                dp[i] = new int[n];
                dp[i][0] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                dp[0][i] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
                }
            }
            return dp[m - 1][n - 1];
        }
    }
}
