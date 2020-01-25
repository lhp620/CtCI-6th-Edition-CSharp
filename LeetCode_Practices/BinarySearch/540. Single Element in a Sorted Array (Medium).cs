using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.BinarySearch
{
    class _540
    {
        public int singleNonDuplicate(int[] nums)
        {
            int l = 0, h = nums.Length - 1;
            while (l < h)
            {
                int m = l + (h - l) / 2;
                if (m % 2 == 1)
                {
                    m--;   // 保证 l/h/m 都在偶数位，使得查找区间大小一直都是奇数
                }
                if (nums[m] == nums[m + 1])
                {
                    l = m + 2;
                }
                else
                {
                    h = m;
                }
            }
            return nums[l];
        }
    }
}
