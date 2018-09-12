using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _896
    {
        public bool IsMonotonic(int[] A)
        {
            bool monotoneIncreasing = true;
            bool monotoneDecreasing = true;
            // check if it is monotone increasing
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > A[i-1])
                {
                    monotoneIncreasing = false;
                }
            }

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < A[i-1])
                {
                    monotoneDecreasing = false;
                }
            }

            return monotoneIncreasing || monotoneDecreasing;
        }

        public bool IsMonotonic_OnePass(int[] A)
        {
            // compare the near element and use store to indicate if it is increasing or descreasing
            int store = 0;
            for (int i = 1; i < A.Length; i++)
            {
                int temp = 0;
                if(A[i -1] > A[i])
                {
                    temp = 1;
                }
                else if (A[i-1] < A[i])
                {
                    temp = -1;
                }
                else
                {
                    temp = 0;
                }

                if (temp != 0)
                {
                    if (temp != store && store != 0)
                    {
                        return false;
                    }
                    store = temp;
                }
            }

            return true;
        }
    }
}
