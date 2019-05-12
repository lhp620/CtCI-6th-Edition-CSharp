using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    class Dynamic_Programming___Longest_Common_Subsequence
    {
        // https://algorithms.tutorialhorizon.com/dynamic-programming-longest-common-subsequence/
        public static int LCS(string A, string B)
        {
            if (A.Length == 0 || B.Length == 0)
            {
                return 0;
            }

            int lenA = A.Length;
            int lenB = B.Length;

            // check if last chars are same
            if (A[lenA -1] == B[lenB-1])
            {
                return 1 + LCS(A.Substring(0, lenA - 1), B.Substring(0, lenB - 1));
            }
            else
            {
                return Math.Max(LCS(A.Substring(0, lenA - 1), B.Substring(0, lenB - 1)),
                    LCS(A.Substring(0, lenA), B.Substring(0, lenB - 1)));
            }
        }

        public static int find(char[] A, char[] B)
        {
            int[][] LCS = new int[A.Length + 1][];
            for(int i = 0; i < LCS.Length; i++)
            {
                LCS[i] = new int[B.Length + 1];
            }

            // if A is null then LCS of A, B = 0
            for (int i = 0; i< B.Length; i++)
            {
                LCS[0][i] = 0;
            }

            // if B is null then LCS of A, B = 0
            for (int i = 0; i < A.Length; i++)
            {
                LCS[i][0] = 0;
            }

            for (int i = 1; i < A.Length; i ++)
            {
                for (int j = 1; j < A.Length; j++)
                {
                    if (A[i-1] == B[j-1])
                    {
                        LCS[i][j] = LCS[i - 1][j - 1] + 1;
                    }
                    else
                    {
                        LCS[i][j] = Math.Max(LCS[i - 1][j], LCS[i][j - 1]);
                    }
                }
            }

            return LCS[A.Length][B.Length];
        }
    }
}
