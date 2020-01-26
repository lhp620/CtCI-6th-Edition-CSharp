using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter4
{
    public class Find_Minimum_in_Rotated_Sorted_Array
    {
        public int findMin(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            int start = 0, end = nums.Length - 1;
            int target = nums[nums.Length - 1];

            // find the first element <= target
            while (start + 1 < end)
            {   
                //用来控制区间大小
                int mid = start + (end - start) / 2;
                if (nums[mid] <= target)
                {       
                    //如果mid位置上的数字小于等于最右端的数字时，区间向左移动
                    end = mid;
                }
                else
                {
                    start = mid;
                }
            }
            return Math.Min(nums[start], nums[end]);  //最终返回start和end位置上较小的数字即可

        }
    }
}
