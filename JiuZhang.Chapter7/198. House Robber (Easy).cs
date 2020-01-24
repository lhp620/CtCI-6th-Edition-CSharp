using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    class _198
    {
        //https://leetcode.com/problems/house-robber/description/
        public int rob(int[] nums)
        {
            int pre2 = 0, pre1 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int cur = Math.Max(pre2 + nums[i], pre1);
                pre2 = pre1;
                pre1 = cur;
            }
            return pre1;
        }
    }
}
