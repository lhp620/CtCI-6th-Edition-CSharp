using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _1046
    {
        public int LastStoneWeight(int[] stones)
        {
            var s = stones.ToList();
            s.Sort();

            while (s.Count > 1)
            {
                int length = s.Count;
                if (s[length - 1] - s[length - 2] == 0)
                {
                    s.RemoveAt(length - 1);
                    s.RemoveAt(length - 2);
                }
                else
                {
                    var newValue = Math.Abs(s[length - 1] - s[length - 2]);
                    s.RemoveAt(length - 1);
                    s.RemoveAt(length - 2);
                    s.Add(newValue);
                    s.Sort();
                }
            }

            return s.Count > 0 ? s[0] : 0;
        }
    }
}
