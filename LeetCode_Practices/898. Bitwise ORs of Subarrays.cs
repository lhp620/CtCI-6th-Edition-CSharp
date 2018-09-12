using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _898
    {
        public int SubarrayBitwiseORs(int[] A)
        {
            HashSet<int> ans = new HashSet<int>();
            HashSet<int> cur = new HashSet<int>();
            cur.Add(0);
            foreach (int x in A)
            {
                HashSet<int> cur2 = new HashSet<int>();
                foreach (int y in cur)
                    cur2.Add(x | y);
                cur2.Add(x);
                cur = cur2;
                foreach (int c in cur)
                {
                    ans.Add(c);
                }
            }

            return ans.Count;
        }
    }
}
