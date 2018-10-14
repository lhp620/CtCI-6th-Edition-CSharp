using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class RLEIterator
    {

        private Queue<int> sequence = new Queue<int>();

        public RLEIterator(int[] A)
        {
            List<int> ans = new List<int>();
            for(int i = 0; i < A.Length;)
            {
                for (int j = 0; j < A[i]; j++)
                {
                    ans.Add(A[i + 1]);
                }

                i = i + 2;
            }

            foreach (int a in ans)
            {
                sequence.Enqueue(a);
            }
        }

        public int Next(int n)
        {
            if ( n < sequence.Count)
            {
                for (int m = 1; m < n; m++)
                {
                    sequence.Dequeue();
                }
                return sequence.Dequeue();
            }
            else
            {
                return -1;
            }
        }
    }
}
