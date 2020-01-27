using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    class _213
    {
        // https://leetcode.com/problems/house-robber-ii/description/
        // https://leetcode.com/problems/house-robber-ii/discuss/59934/Simple-AC-solution-in-Java-in-O(n)-with-explanation
        public int rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int n = nums.Length;
            if (n == 1)
            {
                return nums[0];
            }
            return Math.Max(rob(nums, 0, n - 2), rob(nums, 1, n - 1));
        }

        private int rob(int[] nums, int first, int last)
        {
            int pre2 = 0, pre1 = 0;
            for (int i = first; i <= last; i++)
            {
                int cur = Math.Max(pre1, pre2 + nums[i]);
                pre2 = pre1;
                pre1 = cur;
            }
            return pre1;
        }
    }
}
