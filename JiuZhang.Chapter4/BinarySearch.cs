using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter4
{
    class BinarySearch
    {
        public int binarySearch(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            int start = 0, end = nums.Length - 1;
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    end = mid;
                }
                else if (nums[mid] < target)
                {
                    start = mid;
                    // or start = mid + 1
                }
                else
                {
                    end = mid;
                    // or end = mid - 1
                }
            }

            if (nums[start] == target)
            {
                return start;
            }
            if (nums[end] == target)
            {
                return end;
            }
            return -1;
        }
    }
}
