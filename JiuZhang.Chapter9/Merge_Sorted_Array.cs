using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter9
{
    class Merge_Sorted_Array
    {
        public int[] MergeSortedArray(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                return null;
            }

            int[] result = new int[a.Length + b.Length];
            int i = 0, j = 0, index = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    result[index++] = a[i];
                }
                else
                {
                    result[index++] = b[j];
                }
            }

            while (i < a.Length)
            {
                result[index++] = a[i++];
            }
            while (j < b.Length)
            {
                result[index++] = b[j];
            }

            return result;
        }
    }
}
