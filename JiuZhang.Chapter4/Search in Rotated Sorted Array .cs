﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter4
{
    class Search_in_Rotated_Sorted_Array
    {
        public int search(int[] A, int target)
        {
            if (A == null || A.Length == 0)
            {
                return -1;
            }

            int start = 0;
            int end = A.Length - 1;
            int mid;

            while (start + 1 < end)
            {
                mid = start + (end - start) / 2;
                if (A[mid] == target)
                {
                    return mid;
                }
                if (A[start] < A[mid])
                {
                    // situation 1, red line
                    if (A[start] <= target && target <= A[mid])
                    {
                        end = mid;
                    }
                    else
                    {
                        start = mid;
                    }
                }
                else
                {
                    // situation 2, green line
                    if (A[mid] <= target && target <= A[end])
                    {
                        start = mid;
                    }
                    else
                    {
                        end = mid;
                    }
                }
            } // while

            if (A[start] == target)
            {
                return start;
            }
            if (A[end] == target)
            {
                return end;
            }
            return -1;
        }
    }
}
