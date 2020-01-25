using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.Greed
{
    class _452
    {
        public int findMinArrowShots(int[][] points)
        {
            if (points.Length == 0)
            {
                return 0;
            }
            Array.Sort(points, ComparingInt);
            int cnt = 1, end = points[0][1];
            for (int i = 1; i < points.Length; i++)
            {
                if (points[i][0] <= end)
                {
                    continue;
                }
                cnt++;
                end = points[i][1];
            }
            return cnt;
        }

        private int ComparingInt(int[] x, int[] y)
        {
            return x[1] - y[1];
        }
    }
}
