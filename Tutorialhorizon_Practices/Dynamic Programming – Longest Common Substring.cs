using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    class Dynamic_Programming___Longest_Common_Substring
    {
        //https://algorithms.tutorialhorizon.com/dynamic-programming-longest-common-substring/
        public static int find(char[] A, char[] B)
        {
            int[][] LCS = new int[A.Length + 1][];

            for (int i = 0; i < LCS.Length; i++)
            {
                LCS[i] = new int[B.Length + 1];
            }

            // if A is null then LCS of A and B = 0
            for (int i = 0; i < B.Length; i++)
            {
                LCS[0][i] = 0;
            }

            for (int i = 0; i<A.Length; i++)
            {
                LCS[i][0] = 0;
            }

            // fill the reset of the matrix
            for (int i = 1; i < A.Length; i++)
            {
                for (int j = 1; j < B.Length; j++)
                {
                    if (A[i-1] == B[j-1])
                    {
                        LCS[i][j] = LCS[i - 1][j - 1] + 1;
                    }
                    else
                    {
                        LCS[i][j] = 0;
                    }
                }
            }

            //return LCS.Max().Max();
            int result = -1;
            for (int i = 1; i < A.Length; i++)
            {
                for (int j = 1; j < B.Length; j++)
                {
                    if (result < LCS[i][j])
                    {
                        result = LCS[i][j];
                    }
                }
            }

            return result;
        }
    }
}
