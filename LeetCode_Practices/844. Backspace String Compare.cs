using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _844
    {
        public bool BackspaceCompare(string S, string T)
        {
            // prepare two stack for these two strings
            Stack<char> s1 = new Stack<char>();
            Stack<char> s2 = new Stack<char>();

            foreach (char s in S.ToCharArray())
            {
                if (s != '#')
                {
                    s1.Push(s);
                }
                else if (s1.Count > 0)
                {
                    s1.Pop();
                }
            }

            foreach (char t in T.ToCharArray())
            {
                if (t != '#')
                {
                    s2.Push(t);
                }
                else if (s2.Count > 0)
                {
                    s2.Pop();
                }
            }

            if (s1.Count != s2.Count) return false;
            else
            {
                while(s1.Count > 0)
                {
                    if (s1.Pop() != s2.Pop()) return false;
                }
            }

            return true;
        }
    }
}
