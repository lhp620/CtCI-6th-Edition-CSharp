using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    // https://algorithms.tutorialhorizon.com/longest-palindromic-subsequence/
    class Longest_Palindromic_Subsequence
    {
        public int findPalindrome(string A)
        {
            char[] chars = A.ToCharArray();
            int[][] LP = new int[A.Length][];
            for(int i = 0; i < A.Length; i++)
            {
                LP[i] = new int[A.Length];
            }

            for (int sublen = 2; sublen < A.Length; sublen++)
            {
                for (int i = 0; i < LP.Length - sublen; i++)
                {
                    int j = i + sublen - 1;
                    if (chars[i] == chars[j] && sublen ==2)
                    {
                        LP[i][j] = 2;
                    }
                    else if (chars[i] == chars[j])
                    {
                        LP[i][j] = LP[i + 1][j - 1] + 2;
                    }
                    else
                    {
                        LP[i][j] = Math.Max(LP[i + 1][j], LP[i][j - 1]);
                    }
                }
            }

            return LP[0][LP.Length - 1];
        }
    }
}
