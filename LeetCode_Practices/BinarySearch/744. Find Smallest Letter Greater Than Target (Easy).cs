using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.BinarySearch
{
    class _744
    {
        public char nextGreatestLetter(char[] letters, char target)
        {
            int n = letters.Length;
            int l = 0, h = n - 1;
            while (l <= h)
            {
                int m = l + (h - l) / 2;
                if (letters[m] <= target)
                {
                    l = m + 1;
                }
                else
                {
                    h = m - 1;
                }
            }
            return l < n ? letters[l] : letters[0];
        }
    }
}
