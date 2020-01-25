using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.Greed
{
    class _665
    {
        public bool checkPossibility(int[] nums)
        {
            int cnt = 0;
            for (int i = 1; i < nums.Length && cnt < 2; i++)
            {
                if (nums[i] >= nums[i - 1])
                {
                    continue;
                }
                cnt++;
                if (i - 2 >= 0 && nums[i - 2] > nums[i])
                {
                    nums[i] = nums[i - 1];
                }
                else
                {
                    nums[i - 1] = nums[i];
                }
            }
            return cnt <= 1;
        }
    }
}
