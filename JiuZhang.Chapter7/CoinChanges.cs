using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    // https://leetcode.com/problems/coin-change/
    class CoinChanges
    {
        public int coinChange_topdown(int[] coins, int amount)
        {
            if (amount < 1) return 0;
            return coinChange(coins, amount, new int[amount]);
        }

        private int coinChange(int[] coins, int rem, int[] count)
        {
            if (rem < 0) return -1;
            if (rem == 0) return 0;
            if (count[rem - 1] != 0) return count[rem - 1];
            int min = int.MaxValue;
            foreach (int coin in coins)
            {
                int res = coinChange(coins, rem - coin, count);
                if (res >= 0 && res < min)
                    min = 1 + res;
            }
            count[rem - 1] = (min == int.MaxValue) ? -1 : min;
            return count[rem - 1];
        }

        public int coinChange_BottomUp(int[] coins, int amount)
        {
            int max = amount + 1;
            int[] dp = new int[amount + 1];
            for (int i = 0; i < amount + 1; i++) dp[i] = int.MaxValue;
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                    }
                }
            }
            return dp[amount] > amount ? -1 : dp[amount];
        }
    }
}
