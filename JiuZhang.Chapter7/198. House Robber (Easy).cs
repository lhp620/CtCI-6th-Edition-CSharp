using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    class _198
    {
        // https://leetcode.com/problems/house-robber/description/
        // https://leetcode.com/problems/house-robber/discuss/156523/From-good-to-great.-How-to-approach-most-of-DP-problems.
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

        public int rob2(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int[] memo = new int[nums.Length + 1];
            memo[0] = 0;
            memo[1] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int val = nums[i];
                memo[i + 1] = Math.Max(memo[i], memo[i - 1] + val);
            }
            return memo[nums.Length];
        }
    }
}
