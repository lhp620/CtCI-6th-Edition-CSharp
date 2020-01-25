using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.Greed
{
    class _53
    {
        public int maxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int preSum = nums[0];
            int maxSum = preSum;
            for (int i = 1; i < nums.Length; i++)
            {
                preSum = preSum > 0 ? preSum + nums[i] : nums[i];
                maxSum = Math.Max(maxSum, preSum);
            }
            return maxSum;
        }
    }
}
