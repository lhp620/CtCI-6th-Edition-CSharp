using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _870
    {
        public int[] AdvantageCount(int[] A, int[] B)
        {
            // put B into dictionary to save the order
            Dictionary<int, int> dicB = new Dictionary<int, int>();
            for (int i = 0; i < B.Length; i++)
            {
                dicB[B[i]] = i;
            }

            // sort by A and B
            Array.Sort(A);
            Array.Sort(B);

            // make a permutant of A to max advantage B
            int[] answer = new int[A.Length];
            for (int i = 0; i < B.Length; i++)
            {
                answer[dicB[B[i]]] = A[i];
            }

            return answer;
        }
    }
}
