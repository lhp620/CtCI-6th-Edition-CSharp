using System;
using System.Collections.Generic;
using System.Text;

namespace JiuZhang.Chapter3
{
    class Two_Sum_Input_Array_Is_Sorted
    {
        public static int[] TwoSumInputArrayIsSorted(int[] array, int target)
        {
            if (array == null || array.Length ==0)
            {
                return null;
            }

            int start = 0, end = array.Length - 1;
            while (start + 1 < end)
            {
                if (array[start] + array[end] == target)
                {
                    int[] pair = new int[2];
                    pair[0] = start + 1;
                    pair[1] = end + 1;
                    return pair;
                }
                else if (array[start] + array[end] < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            return null;
        }
    }
}
