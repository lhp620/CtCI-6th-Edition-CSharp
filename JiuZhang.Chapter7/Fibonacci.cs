using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    class Fibonacci
    {
        //Memoization (Top Down)
        // use recursion to resolve problem, directly call the last answer and then call the recursive function untill the bottom to find answer
        public int fib_topdown(int n)
        {
            int[] lookup = new int[Int32.MaxValue];
            for (int i = 0; i < Int32.MaxValue; i++)
                lookup[i] = -1;

            int result = helper(n, lookup);
            return result;
        }

        private static int helper(int n, int[] lookup)
        {
            if (lookup[n] == -1)
            {
                if (n <= 1)
                    lookup[n] = n;
                else
                    lookup[n] = helper(n - 1, lookup) + helper(n - 2, lookup);
            }
            return lookup[n];
        }

        // bottom up 
        int fib(int n)
        {
            int[] f = new int[n + 1];
            f[0] = 0;
            f[1] = 1;
            for (int i = 2; i <= n; i++)
                f[i] = f[i - 1] + f[i - 2];
            return f[n];
        }

    }
}
