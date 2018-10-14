using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _873
    {
        public int LenLongestFibSubseq(int[] A)
        {
            int maxLength = 0;
            for (int i = 0; i < A.Length; i++)
            {
                maxLength = Math.Max(maxLength, MaxFib(A, i));
            }

            return maxLength;
        }

        private int MaxFib(int[] A, int index)
        {
            int maxLength = 0;

            for (int i = index + 1; i < A.Length; i++)
            {
                int count = 0;
                int first = A[index];
                int second = A[i];
                while(A.Contains(first + second))
                {
                    count++;
                    int temp = first;
                    first = second;
                    second = temp + second;
                }

                if (count > 0)
                {
                    maxLength = Math.Max(count + 2, maxLength);
                }
            }

            return maxLength;
        }

        public int LenlongestFibSubseq(int[] A)
        {
            int res = 0;
            int[][] dp = new int[A.Length][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[A.Length];
            }

            Dictionary<int, int> index = new Dictionary<int, int>();
            
            for (int j = 0; j < A.Length; j++)
            {
                index[A[j]] = j;
                for(int i = 0; i < j; i++)
                {
                    int k = -1;
                    if (index.ContainsKey(A[j] - A[i]))
                    {
                        k = index[A[j] - A[i]];
                    }
                    dp[i][j] = (A[j] - A[i] < A[i] && k >= 0) ? dp[k][i] + 1 : 2;
                    res = Math.Max(res, dp[i][j]);
                }
            }
            return res > 2 ? res : 0;
        }
    }
}
