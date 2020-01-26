using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter2
{
    class GetMaximumGold
    {
        //https://leetcode.com/problems/path-with-maximum-gold/
        int[][] grid;
        bool[][] seen;
        int[] d = { 0, 1, 0, -1, 0 };

        public int area(int r, int c, int sum)
        {
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length ||
                    seen[r][c] || grid[r][c] == 0)
                return sum;
            seen[r][c] = true;
            sum += grid[r][c];
            int mx = 0;
            for (int k = 0; k < 4; ++k)
            { // traverse 4 neighbors to get max value.
                mx = Math.Max(mx, area(r + d[k], c + d[k + 1], sum));
            }
            seen[r][c] = false;
            return mx;
        }

        public int GetMaximumGold_(int[][] grid)
        {
            this.grid = grid;
            seen = new bool[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                seen[i] = new bool[grid[0].Length];
            }

            int ans = 0;
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    ans = Math.Max(ans, area(r, c, 0));
                }
            }
            return ans;
        }
    }
}
