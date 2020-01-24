using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.DFS
{
    class _200
    {
        private int m, n;
        private int[][] direction = new int[][]{ new int[]{ 0, 1 }, new int[]{ 0, -1 }, new int[]{ 1, 0 }, new int[]{ -1, 0 } };

        public int numIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }
            m = grid.Length;
            n = grid[0].Length;
            int islandsNum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] != '0')
                    {
                        dfs(grid, i, j);
                        islandsNum++;
                    }
                }
            }
            return islandsNum;
        }

        private void dfs(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] == '0')
            {
                return;
            }
            grid[i][j] = '0';
            foreach (int[] d in direction)
            {
                dfs(grid, i + d[0], j + d[1]);
            }
        }
    }
}
