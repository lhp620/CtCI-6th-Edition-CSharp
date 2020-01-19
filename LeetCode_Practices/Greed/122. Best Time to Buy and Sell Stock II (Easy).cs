using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.Greed
{
    class _122
    {
        public int maxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += (prices[i] - prices[i - 1]);
                }
            }
            return profit;
        }
    }
}
