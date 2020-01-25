using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.Greed
{
    class _121
    {
        public int maxProfit(int[] prices)
        {
            int n = prices.Length;
            if (n == 0) return 0;
            int soFarMin = prices[0];
            int max = 0;
            for (int i = 1; i < n; i++)
            {
                if (soFarMin > prices[i]) soFarMin = prices[i];
                else max = Math.Max(max, prices[i] - soFarMin);
            }
            return max;
        }
    }
}
