using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter4
{
    public class Maximum_Number_in_Mountain_Sequence
    {
        public int mountainSequence(int[] nums)
        {
            // Write your code here
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int start = 0;
            int end = nums.Length - 1;
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    end = mid;
                }
                else
                {
                    start = mid;
                }
            }
            return Math.Max(nums[start], nums[end]);
        }
    }
}
