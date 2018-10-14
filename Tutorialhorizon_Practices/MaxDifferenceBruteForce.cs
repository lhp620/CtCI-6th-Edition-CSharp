using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    class MaxDifferenceBruteForce
    {
        //https://algorithms.tutorialhorizon.com/maximum-difference-between-two-elements-where-larger-element-appears-after-the-smaller-element/
		public static int MaxDifference(int[] A)
        {
            int maxDiff = -1;
			for(int i = 0; i <A.Length; i++)
            {
				for (int j = 1; j < A.Length; j++)
                {
					if (A[j] < A[i] && A[j] - A[i] > maxDiff)
                    {
                        maxDiff = A[j] - A[i];
                    }
                }
            }

            return maxDiff;
        }

		public static int MaxDifference(int[] A, int start, int end)
        {
			if (start >= end)
            {
                return -1;
            }

            int mid = start + (end - start) / 2;
            int leftDiff = MaxDifference(A, start, mid);
            int rightDiff = MaxDifference(A, mid, end);
            int minLeft = getMin(A, start, mid);
            int maxRight = getMax(A, mid, end);
            int CenterDiff = maxRight - minLeft;
            return Math.Max(CenterDiff, Math.Max(leftDiff, rightDiff));
        }

		public static int getMin(int[] A, int i, int j)
        {
            int min = A[i];
			for (int k = i + 1; k < j; k++)
            {
				if (A[k] < min)
                {
                    min = A[k];
                }
            }
            return min;
        }

		public static int getMax (int[] A, int i, int j)
        {
            int max = A[i];
			for (int k = i + 1; k < j;k++)
            {
				if (A[k] > max)
                {
                    max = A[k];
                }
            }

            return max;
        }

		public static int maxDifference(int[] A)
        {
            int size = A.Length;
            int maxDiff = -1;
            int max_so_far = A[size - 1];
			for (int i = size -2; i > 0; i--)
            {
				if (max_so_far < A[i])
                {
                    max_so_far = A[i];
                }
				else if (max_so_far > A[i])
                {
                    maxDiff = Math.Max(maxDiff, max_so_far - A[i]);
                }
            }

            return maxDiff;
        }
    }
}
