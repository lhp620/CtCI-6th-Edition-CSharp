using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ctci.Contracts;

namespace JiuZhang.Chapter2
{
    public class Binary_Search
    {
        /// <summary>
        /// find the first index of targt in array, if not find, return -1
        /// if asking for any existing index, not need check start and end at the end of code, directly return in while loop
        /// if asking for last index, change start = middle in while loop and check end index value == target at the end of code
        /// </summary>
        public static int BinarySearch(int[] array, int target)
        {
            // sanity check parameters 
            if (array == null || array.Length == 0)
            {
                return -1;
            }

            // two points 
            int start = 0;
            int end = array.Length - 1;

            // quit when start and end point to the last two elements to avoid some endless loop
            while (start + 1 < end)
            {
                int middle = start + (end - start) / 2;
                if (array[middle] > target)
                {
                    end = middle - 1;
                }
                else if (array[middle] < target)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle;
                }
            }

            // check if start or end index match the target
            if (array[start] == target)
            {
                return start;
            }
            else if (array[end] == target)
            {
                return end;
            }
            else
            {
                return -1;
            }
        }
    }
}
