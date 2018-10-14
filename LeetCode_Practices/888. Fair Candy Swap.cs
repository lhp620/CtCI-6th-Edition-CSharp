using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _888
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            Array.Sort(A);
            Array.Sort(B);
            int[] answers = new int[2];
            // get the total of A and B
            int totalA = 0, totalB = 0;
            foreach (int a in A)
            {
                totalA += a;
            }
            foreach (int b in B)
            {
                totalB += b;
            }

            // compare the total A and B to get which is larger 
            int i = 0, j = 0;
            while (i < A.Length && j < B.Length)
            {
                // swith the last value of A with the first one of B
                if (totalA - A[i] + B[j] < totalB - B[j] + A[i])
                {
                    j++;
                }
                else if (totalA - A[i] + B[j] > totalB - B[j] + A[i])
                {
                    i++;
                }
                else
                {
                    answers[0] = A[i];
                    answers[1] = B[j];
                    break;
                }
            }

            return answers;
        }
    }
}
