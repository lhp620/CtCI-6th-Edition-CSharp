using System;

namespace Ch_08._Recursion_and_Dynamic_Programming
{
    public class Q8_01_Triple_Step
    {
        // brute force
        public int CountWays(int n)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                return CountWays(n - 1) + CountWays(n - 2) + CountWays(n - 3);
            }
        }
        
        // Memoization solution
        public int CountWays_d(int n)
        {
            int[] memo = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                memo[i] = -1;
            }

            return CountWays_d(n, memo);
        }

        public int CountWays_d(int n, int[] memo)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;
            }
            else if (memo[n] > -1)
            {
                return memo[n];
            }
            else
            {
                memo[n] = CountWays_d(n - 1, memo) + CountWays_d(n - 2, memo) + CountWays_d(n - 3, memo);
                return memo[n];
            }
        }
    }
}
