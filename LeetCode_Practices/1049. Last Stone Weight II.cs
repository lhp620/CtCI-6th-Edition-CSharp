using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _1049
    {
        public int LastStoneWeightII(int[] A)
        {
            bool[] dp = new bool[1501];
            dp[0] = true;

            int sumA = 0;
            int res = 0;
            foreach (var a in A)
            {
                sumA += a;
                for (int i = 1500; i >= a; --i)
                {
                    dp[i] = dp[i] | dp[i - a];
                }
            }

            for (int i = sumA / 2; i > 0; --i)
            {
                if (dp[i])
                {
                    return sumA - i - i;
                }
            }

            return 0;
        }
    }
}
