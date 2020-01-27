using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    class _279
    {
        //https://leetcode.com/problems/perfect-squares/description/
        public int numSquares(int n)
        {
            List<int> squareList = generateSquareList(n);
            int[] dp = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                int min = int.MaxValue;
                foreach (int square in squareList)
                {
                    if (square > i)
                    {
                        break;
                    }
                    min = Math.Min(min, dp[i - square] + 1);
                }
                dp[i] = min;
            }
            return dp[n];
        }

        private List<int> generateSquareList(int n)
        {
            List<int> squareList = new List<int>();
            int diff = 3;
            int square = 1;
            while (square <= n)
            {
                squareList.Add(square);
                square += diff;
                diff += 2;
            }
            return squareList;
        }

        // https://leetcode.com/problems/perfect-squares/discuss/71495/An-easy-understanding-DP-solution-in-Java
        public int numSquares2(int n)
        {
            int[] dp = new int[n + 1];
            for (int i = 0; i < n+1; i++)
            {
                dp[i] = int.MaxValue;
            }
            dp[0] = 0;
            for (int i = 1; i <= n; ++i)
            {
                int min = int.MaxValue;
                int j = 1;
                while (i - j * j >= 0)
                {
                    min = Math.Min(min, dp[i - j * j] + 1);
                    ++j;
                }
                dp[i] = min;
            }
            return dp[n];
        }
    }
}
