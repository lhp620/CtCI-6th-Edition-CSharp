using System;
using System.Collections.Generic;
using System.Text;

namespace JiuZhang.Chapter3
{
    class Two_Sum_Unique_Pairs
    {
        // find unique pairs' sum equal to target
        public static int TwoSumUniquePairs(int[] array, int target)
        {
            if(array == null || array.Length == 0)
            {
                return 0;
            }

            Array.Sort(array);

            int cnt = 0;
            int left = 0, right = array.Length - 1;
            while (left + 1 < right)
            {
                int v = array[left] + array[right];

                if (v == target)
                {
                    cnt++;
                    left++;
                    right--;
                    // find the next right which is different than the current one
                    while (left < right && array[right] == array[right +1])
                    {
                        right--;
                    }
                    // find the next left which is different than the current one
                    while (left <right && array[left] == array[left-1])
                    {
                        left++;
                    }
                }
                else if (v > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return cnt;
        }
    }
}
