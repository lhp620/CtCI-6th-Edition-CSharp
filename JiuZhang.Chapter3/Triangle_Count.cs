using System;
using System.Collections.Generic;
using System.Text;

namespace JiuZhang.Chapter3
{
    public class Triangle_Count
    {
        // find the possible combinations in array which could compose to triangle 
        public static int TriangleCount(int[] s)
        {
            int ans = 0;
            int length = s.Length;

            Array.Sort(s);

            // Fix the first element.  We need to run till n-3 as
            // the other two elements are selected from arr[i+1...n-1]
            for (int i = 0; i < length - 2; i++)
            {
                // Initialize index of the rightmost third element
                int k = i + 2;

                // Fix the second element
                for (int j = i + 1; j < length - 1; j++)
                {
                    /* Find the rightmost element which is smaller
                       than the sum of two fixed elements
                       The important thing to note here is, we use
                       the previous value of k. If value of arr[i] +
                       arr[j-1] was greater than arr[k], then arr[i] +
                       arr[j] must be greater than k, because the
                       array is sorted. */
                    while (k < length && s[i] + s[j] > s[k])
                    {
                        k++;
                    }

                    /* Total number of possible triangles that can be
                       formed with the two fixed elements is k - j - 1.
                       The two fixed elements are arr[i] and arr[j].  All
                       elements between arr[j+1] to arr[k-1] can form a
                       triangle with arr[i] and arr[j]. One is subtracted
                       from k because k is incremented one extra in above
                       while loop. k will always be greater than j. If j
                       becomes equal to k, then above loop will increment
                       k, because arr[k] + arr[i] is always/ greater than
                       arr[k] */
                    ans += k - j - 1;
                }
            }
            return ans;
        }
    }
}
