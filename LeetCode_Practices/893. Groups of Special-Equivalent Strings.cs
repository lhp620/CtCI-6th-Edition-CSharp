using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _893
    {
        public int numSpecialEquivGroups(String[] A)
        {
            HashSet<String> seen = new HashSet<string>();
            foreach (String S in A)
            {
                int[] count = new int[52];
                for (int i = 0; i < S.Length; ++i)
                    count[S[i] - 'a' + 26 * (i % 2)]++;
                seen.Add(count.ToString());
            }
            return seen.Count;
        }
    }
}
