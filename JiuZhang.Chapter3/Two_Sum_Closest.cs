using System;
using System.Collections.Generic;
using System.Text;

namespace JiuZhang.Chapter3
{
    public class Two_Sum_Closest
    {
        public static int TwoSumClosest(int[] nums, int target)
        {
            if (nums == null || nums.Length == 1)
            {
                return -1;
            }

            Array.Sort(nums);

            int left = 0, right = nums.Length - 1;
            int diff = int.MaxValue;

            while (left < right)
            {
                if (nums[left] + nums[right] < target)
                {
                    diff = Math.Min(diff, target - nums[left] - nums[right]);
                    left++;
                }
                else
                {
                    diff = Math.Min(diff, nums[left] + nums[right] - target);
                    right--;
                }
            }

            return diff;
        }
    }
}
