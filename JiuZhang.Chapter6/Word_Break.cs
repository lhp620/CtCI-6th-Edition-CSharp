using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    public class Word_Break
    {
        public static bool WordBreak(string s, List<string> dict)
        {
            bool[] f = new bool[s.Length + 1];

            f[0] = true;

            for (int i = 1; i < s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    //?
                    if (f[j] && dict.Contains(s.Substring(j, i-j)))
                    {
                        f[i] = true;
                        break;
                    }
                }
            }

            return f[s.Length];
        }

        public static bool WordBreak_(string s, List<string> dict)
        {
            int size = s.Length;

            // base case
            if (size == 0)
            {
                return true;
            }

            // try all prefix of lengths from 1 to size
            for (int i = 1; i <=size; i++)
            {
                // check prefix substring 0 to i and recursively call wordbreak for suffix 
                if (dict.Contains(s.Substring(0,i)) && WordBreak_(s.Substring(i, size - i), dict))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
