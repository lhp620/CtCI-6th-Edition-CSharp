using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _1232
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            int p = coordinates[0][0], q = coordinates[0][1], u = coordinates[1][0], v = coordinates[1][1];

            foreach (int[] c in coordinates)
            {
                if((c[0] - p) * (c[1] - v) != (c[0]- u) * (c[1] - q))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
