using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    // https://algorithms.tutorialhorizon.com/dynamic-programming-maximum-subarray-problem/
    class MaximumSubArrayDP
    {
        // bottom up approach
        public int solve(int[] a)
        {
            int[] solution = new int[a.Length + 1];
            solution[0] = 0;

            for (int j =1; j < solution.Length; j++)
            {
                solution[j] = Math.Max(solution[j - 1] + a[j - 1], a[j - 1]);
            }

            // find the largest number in soltion
            return solution.Max();
        }

        public int Kandane(int[] arrA)
        {
            int max_end_here = 0;
            int max_so_far = 0;

            for (int i = 0; i < arrA.Length; i++)
            {
                max_end_here += arrA[i];
                if (max_end_here < 0)
                {
                    max_end_here = 0;
                }
                if (max_so_far < max_end_here)
                {
                    max_so_far = max_end_here;
                }
            }

            return max_so_far;
        }

        // Below modification will allow the program to work even if all the
        // elements in the array are negative
        public int KandaneModify(int[] arrA)
        {
            int max_end_here = arrA[0];
            int max_so_far = arrA[0];

            for (int i = 1; i< arrA.Length; i++)
            {
                max_end_here = Math.Max(arrA[i], max_end_here + arrA[i]);
                max_so_far = Math.Max(max_so_far, max_end_here);
            }

            return max_so_far;
        }
    }
}
