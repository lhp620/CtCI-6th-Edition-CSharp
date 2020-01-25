using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.BinarySearch
{
    class _278
    {
        public int firstBadVersion(int n)
        {
            int l = 1, h = n;
            while (l < h)
            {
                int mid = l + (h - l) / 2;
                if (IsBadVersion(mid))
                {
                    h = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return l;
        }

        private bool IsBadVersion(int mid)
        {
            throw new NotImplementedException();
        }
    }
}
