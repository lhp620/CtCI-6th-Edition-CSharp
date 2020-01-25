using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.Greed
{
    class _392
    {
        public bool isSubsequence(String s, String t)
        {
            int index = -1;
            foreach (char c in s.ToCharArray())
            {
                index = t.IndexOf(c, index + 1);
                if (index == -1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
