using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _836
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            return !(rec1[2] <= rec2[0] ||   // left
             rec1[3] <= rec2[1] ||   // bottom
             rec1[0] >= rec2[2] ||   // right
             rec1[1] >= rec2[3]);    // top
        }
    }
}
