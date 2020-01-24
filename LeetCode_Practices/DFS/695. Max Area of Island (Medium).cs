using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.DFS
{
    class _695
    {
        private int m, n;
        private int[][] direction = new int[][]{ new int[]{ 0, 1 }, new int[]{ 0, -1 }, new int[]{ 1, 0 }, new int[]{ -1, 0 } };

        public int maxAreaOfIsland(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }
            m = grid.Length;
            n = grid[0].Length;
            int maxArea = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    maxArea = Math.Max(maxArea, dfs(grid, i, j));
                }
            }
            return maxArea;
        }

        private int dfs(int[][] grid, int r, int c)
        {
            if (r < 0 || r >= m || c < 0 || c >= n || grid[r][c] == 0)
            {
                return 0;
            }
            grid[r][c] = 0;
            int area = 1;
            foreach (int[] d in direction)
            {
                area += dfs(grid, r + d[0], c + d[1]);
            }
            return area;
        }
    }
}
