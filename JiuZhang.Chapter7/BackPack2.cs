using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter8
{
    class BackPack2
    {
        public int BackPack_2(int m, int[] A, int[] V)
        {
            // for A, the ith element, put into j size backpack, the max value
            int[][] dp = new int[A.Length + 1][];
            for(int i = 0; i < A.Length; i++)
            {
                dp[i] = new int[m];
            }

            for (int i = 0; i <= A.Length; i++)
            {
                for(int j = 0; j <= m; j++)
                {
                    if (i == 0 || j ==0)
                    {
                        dp[i][j] = 0;
                    }
                    else if (A[i-1] > j)
                    {
                        dp[i][j] = dp[i - 1][j];
                    }
                    else
                    {
                        dp[i][j] = Math.Max(dp[i - 1][j], dp[i - 1][j - A[i - 1]] + V[i - 1]);
                    }
                }
            }

            return dp[A.Length][m];
        }

        public int BackPack_2_2(int m, int[] A, int[] V)
        {
            int[] f = new int[m + 1];
            for (int i = 0; i <= m; i++) f[i] = 0;
            int n = A.Length - 1;
            for(int i = 0; i < n; i++)
            {
                for(int j = m; j > A[i]; j--)
                {
                    if(f[j] < f[j - A[i]] + V[i])
                    {
                        f[j] = f[j - A[i]] + V[i];
                    }
                }
            }

            return f[m];

        }
    }
}
