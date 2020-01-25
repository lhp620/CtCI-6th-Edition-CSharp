using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.DFS
{
    class _417
    {
        private int m, n;
        private int[][] matrix;
        private int[][] direction = new int[][]{ new int[]{ 0, 1 }, new int[]{ 0, -1 }, new int[]{ 1, 0 }, new int[]{ -1, 0 } };

        public IList<IList<int>> pacificAtlantic(int[][] matrix)
        {
            IList<IList<int>> ret = new List<IList<int>>();
            if (matrix == null || matrix.Length == 0)
            {
                return ret;
            }

            m = matrix.Length;
            n = matrix[0].Length;
            this.matrix = matrix;
            bool[][] canReachP = new bool[m][];
            bool[][] canReachA = new bool[m][];

            for (int i = 0; i < m; i++)
            {
                dfs(i, 0, canReachP);
                dfs(i, n - 1, canReachA);
            }
            for (int i = 0; i < n; i++)
            {
                dfs(0, i, canReachP);
                dfs(m - 1, i, canReachA);
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (canReachP[i][j] && canReachA[i][j])
                    {
                        ret.Add(new List<int>() {i, j});
                    }
                }
            }

            return ret;
        }

        private void dfs(int r, int c, bool[][] canReach)
        {
            if (canReach[r][c])
            {
                return;
            }
            canReach[r][c] = true;
            foreach (int[] d in direction)
            {
                int nextR = d[0] + r;
                int nextC = d[1] + c;
                if (nextR < 0 || nextR >= m || nextC < 0 || nextC >= n
                        || matrix[r][c] > matrix[nextR][nextC])
                {

                    continue;
                }
                dfs(nextR, nextC, canReach);
            }
        }
    }
}
