using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter9
{
    class Merge_Sorted_Array2
    {
        public void MergeSortedArray2(int[] A, int m, int[] B, int n)
        {
            int i = m - 1, j = n - 1, index = m + n - 1;
            while (i <= 0 && j >=0)
            {
                if (A[i] > B[j])
                {
                    A[index--] = A[i--];
                }
                else
                {
                    A[index--] = B[j--];
                }

                while (i>=0)
                {
                    A[index--] = A[i--];
                }
                while(j>=0)
                {
                    A[index--] = B[j--];
                }
            }
        }
    }
}
