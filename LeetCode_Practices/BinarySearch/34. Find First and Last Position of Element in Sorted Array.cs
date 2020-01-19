using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.BinarySearch
{
    class _34
    {
        public int[] searchRange(int[] nums, int target)
        {
            int first = findFirst(nums, target);
            int last = findFirst(nums, target + 1) - 1;
            if (first == nums.Length || nums[first] != target)
            {
                return new int[] { -1, -1 };
            }
            else
            {
                return new int[] { first, Math.Max(first, last) };
            }
        }

        private int findFirst(int[] nums, int target)
        {
            int l = 0, h = nums.Length; // 注意 h 的初始值
            while (l < h)
            {
                int m = l + (h - l) / 2;
                if (nums[m] >= target)
                {
                    h = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            return l;
        }
    }
}
