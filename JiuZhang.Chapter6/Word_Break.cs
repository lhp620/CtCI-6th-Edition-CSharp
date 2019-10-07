using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    public class Word_Break
    {
        //https://leetcode.com/problems/word-break/
        //https://www.youtube.com/watch?v=ptlwluzeC1I
        public static bool WordBreak_Dynamic(string s, List<string> dict)
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

        public static bool WordBreak_Dynamic2(string s, List<string> dict)
        {
            bool[] f = new bool[s.Length + 1];

            f[0] = true;

            for (int i = 1; i < s.Length; i++)
            {
                foreach (string d in dict)
                {
                    // d matches with the right part of the s.Substring(0, i)
                    if (f[i - d.Length] && d == s.Substring(i-d.Length))
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


        public bool WordBreak__(string s, List<string> dic)
        {
            bool[] memory = new bool[s.Length + 1];
            memory[0] = true;
            return WordBreakHelper__(s, dic, memory);
        }

        private bool WordBreakHelper__(string s, List<string> dic, bool[] memory)
        {
            if (memory[s.Length]) return memory[s.Length];
            if (dic.Contains(s)) return memory[s.Length] = true;

            for (int j = 1; j < s.Length; j++)
            {
                string left = s.Substring(0, j);
                string right = s.Substring(j);

                if(dic.Contains(right) && WordBreakHelper__(left, dic, memory))
                {
                    return memory[s.Length] = true;
                }
            }

            return memory[s.Length] = false;
        }
    }
}
