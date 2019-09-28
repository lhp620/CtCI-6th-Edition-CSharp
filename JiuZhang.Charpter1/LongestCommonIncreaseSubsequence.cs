using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Charpter1
{
    class FindLengthOfLCIS
    {
        // sliding window
        public int findLengthOfLCIS(int[] nums)
        {
            int ans = 0, anchor = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (i > 0 && nums[i - 1] >= nums[i]) anchor = i;
                ans = Math.Max(ans, i - anchor + 1);
            }
            return ans;
        }
    }
}
