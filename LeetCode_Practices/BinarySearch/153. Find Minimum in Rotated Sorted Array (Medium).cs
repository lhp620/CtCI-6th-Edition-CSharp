using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.BinarySearch
{
    class _153
    {
        public int findMin(int[] nums)
        {
            int l = 0, h = nums.length - 1;
            while (l < h)
            {
                int m = l + (h - l) / 2;
                if (nums[m] <= nums[h])
                {
                    h = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            return nums[l];
        }
    }
}
