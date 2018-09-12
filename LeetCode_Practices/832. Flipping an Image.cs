using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _832
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            // flip an image horizontally
            for (int j = 0; j < A.Length; j++)
            {
                for (int i = 0; i < A[0].Length / 2; i++)
                {
                    int temp = A[j][i];
                    A[j][i] = A[j][A[0].Length - i];
                    A[j][A[0].Length - i] = temp;
                }
            }

            // invert an image
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[0].Length; j++)
                {
                    if (A[i][j] == 0)
                    {
                        A[i][j] = 1;
                    }
                    else
                    {
                        A[i][j] = 0;
                    }
                }
            }

            return A;
        }
    }
}
