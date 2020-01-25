using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _435
    {
        public int eraseOverlapIntervals(int[][] intervals)
        {
            if (intervals.Length == 0)
            {
                return 0;
            }

            Array.Sort(intervals, ComparingInt);
            
            int cnt = 1;
            int end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] < end)
                {
                    continue;
                }
                end = intervals[i][1];
                cnt++;
            }
            return intervals.Length - cnt;
        }

        private int ComparingInt(int[] o1, int[] o2)
        {
            return o1[1] - o2[1];
        }
    }
}
