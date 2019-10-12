using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter2
{
    class MaxAreaOfIsland
    {
        int[][] grid;
        bool[][] seen;

        public int area(int r, int c)
        {
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length ||
                    seen[r][c] || grid[r][c] == 0)
                return 0;
            seen[r][c] = true;
            return (1 + area(r + 1, c) + area(r - 1, c)
                      + area(r, c - 1) + area(r, c + 1));
        }

        public int maxAreaOfIsland(int[][] grid)
        {
            this.grid = grid;
            seen = new bool[grid.Length][];
            for(int i = 0; i < grid[0].Length; i++)
            {
                seen[i] = new bool[grid[0].Length];
            }

            int ans = 0;
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    ans = Math.Max(ans, area(r, c));
                }
            }
            return ans;
        }
    }
}
