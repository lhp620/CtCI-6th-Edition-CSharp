using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter8
{
    class WildPatternMatching
    {
        public bool StrMatch(string str, string pattern, int n, int m)
        {
            //empty pattern can only match with empty string
            if (m==0)
            {
                return n == 0;
            }

            // lookup talbe for storing results of subproblems
            bool[,] lookup = new bool[n + 1, m + 1];

            // initilize lookup talbe to false
            for (int i = 0; i < n+1;i++)
            {
                for(int j = 0; j < m+1;j++)
                {
                    lookup[i, j] = false;
                }
            }

            // empty pattern can match with empty string
            lookup[0, 0] = true;

            // only * can match with empty string
            for(int j = 1; j <=m;j++)
            {
                if(pattern[j-1] == '*')
                {
                    lookup[0, j] = lookup[0, j - 1];
                }
            }

            // fill the table in bottom up
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <=m; j++)
                {
                    // two case if we meet * 
                    // ignore
                    // * match with ith in string 
                    if (pattern[j-1] == '*')
                    {
                        lookup[i, j] = lookup[i, j - 1] || lookup[i - 1, j];
                    }
                    else if (pattern[j-1] == '?' || str[i-1] == pattern[j-1])
                    {
                        // if the patter is ? or two char from str and patter match
                        lookup[i, j] = lookup[i - 1, j - 1];
                    }
                    else
                    {
                        // not match
                        lookup[i, j] = false;
                    }
                }
            }

            return lookup[n, m];
        }
    }
}
