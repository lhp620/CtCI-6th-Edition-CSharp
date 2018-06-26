using System;
using System.Collections.Generic;
using System.Text;

namespace JiuZhang.Chapter3
{
    class Kth_Smallest_Numbers_In_Unsorted_Array
    {
        // https://www.geeksforgeeks.org/kth-smallestlargest-element-unsorted-array/
        // https://leetcode.com/problems/kth-largest-element-in-an-array/discuss/60294/Solution-explained

        public int KthSmallest(int k, int[] nums)
        {
            return QuickSelect(nums, 0, nums.Length - 1, k - 1);
        }

        private int QuickSelect(int[] A, int start, int end, int k)
        {
            if (start == end)
            {
                return A[start];
            }

            int left = start, right = end;
            int pivot = A[(start + end) / 2];
            while (left < right)
            {
                while(left <= right && A[left] < pivot)
                {
                    left++;
                }

                while(left <= right && A[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    int temp = A[left];
                    A[left] = A[right];
                    A[right] = temp;

                    left++;
                    right--;
                }
            }

            if (right >=k && start <=right)
            {
                return QuickSelect(A, start, right, k);
            }
            else if (left <=k && left <=end)
            {
                return QuickSelect(A, left, end, k);
            }
            else
            {
                return A[k];
            }
        }
    }
}
