using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.Greed
{
    class _605
    {
        public bool canPlaceFlowers(int[] flowerbed, int n)
        {
            int len = flowerbed.Length;
            int cnt = 0;
            for (int i = 0; i < len && cnt < n; i++)
            {
                if (flowerbed[i] == 1)
                {
                    continue;
                }
                int pre = i == 0 ? 0 : flowerbed[i - 1];
                int next = i == len - 1 ? 0 : flowerbed[i + 1];
                if (pre == 0 && next == 0)
                {
                    cnt++;
                    flowerbed[i] = 1;
                }
            }
            return cnt >= n;
        }
    }
}
