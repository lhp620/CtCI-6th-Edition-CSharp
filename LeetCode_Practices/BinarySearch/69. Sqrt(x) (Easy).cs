using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.BinarySearch
{
    class _69
    {
        public int mySqrt(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            int l = 1, h = x;
            while (l <= h)
            {
                int mid = l + (h - l) / 2;
                int sqrt = x / mid;
                if (sqrt == mid)
                {
                    return mid;
                }
                else if (mid > sqrt)
                {
                    h = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return h;
        }
    }
}
