using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    // https://leetcode.com/problems/coin-change-2/
    // https://www.geeksforgeeks.org/coin-change-dp-7/
    class CoinChanges2
    {
        public int change(int amount, int[] coins)
        {
            int[][] dp = new int[coins.Length + 1][];
            for(int i = 0; i < coins.Length + 1; i++)
            {
                dp[i] = new int[amount + 1];
            }

            dp[0][0] = 1;

            for (int i = 1; i <= coins.Length; i++)
            {
                dp[i][0] = 1;
                for (int j = 1; j <= amount; j++)
                {
                    dp[i][j] = dp[i - 1][j] + (j >= coins[i - 1] ? dp[i][j - coins[i - 1]] : 0);
                }
            }
            return dp[coins.Length][amount];
        }

        static long countWays(int[] S, int m, int n)
        {
            //Time complexity of this function: O(mn) 
            //Space Complexity of this function: O(n) 

            // table[i] will be storing the number of solutions 
            // for value i. We need n+1 rows as the table is 
            // constructed in bottom up manner using the base 
            // case (n = 0) 
            int[] table = new int[n + 1];

            // Initialize all table values as 0 
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = 0;
            }

            // Base case (If given value is 0) 
            table[0] = 1;

            // Pick all coins one by one and update the table[] 
            // values after the index greater than or equal to 
            // the value of the picked coin 
            foreach (int coin in S)
                for (int j = coin; j <= n; j++)
                    table[j] += table[j - coin];

            return table[n];
        }
    }
}
