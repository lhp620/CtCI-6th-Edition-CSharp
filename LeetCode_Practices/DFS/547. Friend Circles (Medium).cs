using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.DFS
{
    class _547
    {
        private int n;

        public int findCircleNum(int[][] M)
        {
            n = M.Length;
            int circleNum = 0;
            bool[] hasVisited = new bool[n];
            for (int i = 0; i < n; i++)
            {
                if (!hasVisited[i])
                {
                    dfs(M, i, hasVisited);
                    circleNum++;
                }
            }
            return circleNum;
        }

        private void dfs(int[][] M, int i, bool[] hasVisited)
        {
            hasVisited[i] = true;
            for (int k = 0; k < n; k++)
            {
                if (M[i][k] == 1 && !hasVisited[k])
                {
                    dfs(M, k, hasVisited);
                }
            }
        }
    }
}
