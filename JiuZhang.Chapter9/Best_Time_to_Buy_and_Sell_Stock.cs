using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter9
{
    class Best_Time_to_Buy_and_Sell_Stock
    {
        // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/discuss/39060/Very-Simple-Java-Solution-with-detail-explanation-(1ms-beats-96)
        public int MaxProfile(int[] prices)
        {
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }

            int min = int.MaxValue;
            int profit = 0;

            foreach (int i in prices)
            {
                min = i < min ? i : min;
                profit = (i - min) > profit ? i - min : profit;
            }

            return profit;
        }
    }
}
