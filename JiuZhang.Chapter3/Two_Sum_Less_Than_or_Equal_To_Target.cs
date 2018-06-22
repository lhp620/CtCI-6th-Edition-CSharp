using System;
using System.Collections.Generic;
using System.Text;

namespace JiuZhang.Chapter3
{
    public class Two_Sum_Less_Than_or_Equal_To_Target
    {
        public static int TwoSumLessThanorEqualToTarget(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            Array.Sort(nums);

            int cnt = 0;
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int v = nums[left] + nums[right];
                if (v <= target)
                {
                    // left with any element less than right are the valid pair
                    // like n!
                    cnt += right - left;
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return cnt;
        }
    }
}
