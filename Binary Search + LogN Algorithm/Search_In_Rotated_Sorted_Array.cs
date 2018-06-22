using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter2
{
    public class Search_In_Rotated_Sorted_Array
    {
        // search a target in rotated sorted array
        public static int SearchInRotatedSortedArray(int[] array, int target)
        {
            if (array == null || array.Length == 0)
            {
                return -1;
            }

            int start = 0;
            int end = array.Length - 1;
            int mid;

            while (start + 1 < end)
            {
                mid = start + (end - start) / 2;
                if (array[mid] == target)
                {
                    return mid;
                }

                // the left part is sorted
                if (array[start] < array[mid])
                {
                    // check the target in the sorted left part
                    if (array[start] <= target && target <= array[mid])
                    {
                        end = mid;
                    }
                    else
                    {
                        start = mid;
                    }
                }
                // the right part is sorted
                else
                {
                    if (array[mid] <= target && target <= array[end])
                    {
                        start = mid;
                    }
                    else
                    {
                        end = mid;
                    }
                }
            }

            if (array[start] == target)
            {
                return start;
            }
            else if (array[end] == target)
            {
                return end;
            }

            return -1;
        }
    }
}
