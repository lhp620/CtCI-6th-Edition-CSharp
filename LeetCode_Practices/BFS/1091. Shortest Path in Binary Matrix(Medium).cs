using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.BFS
{
    class _1091
    {
        public int shortestPathBinaryMatrix(int[][] grids)
        {
            int[][] direction = new int[][] { new int[]{ 1, -1 }, new int[]{ 1, 0 }, new int[] { 1, 1 }, new int[] { 0, -1 }, new int[] { 0, 1 }, new int[] { -1, -1 }, new int[] { -1, 0 }, new int[] { -1, 1 } };
            int m = grids.Length, n = grids[0].Length;
            Queue<KeyValuePair<int, int>> queue = new Queue<KeyValuePair<int, int>>();
            queue.Enqueue(new KeyValuePair<int, int>(0, 0));
            int pathLength = 0;
            while (queue.Count > 0)
            {
                int size = queue.Count;
                pathLength++;
                while (size-- > 0)
                {
                    KeyValuePair<int, int> cur = queue.Dequeue();
                    int cr = cur.Key, cc = cur.Value;
                    grids[cr][cc] = 1; // 标记
                    foreach (int[] d in direction)
                    {
                        int nr = cr + d[0], nc = cc + d[1];
                        if (nr < 0 || nr >= m || nc < 0 || nc >= n || grids[nr][nc] == 1)
                        {
                            continue;
                        }
                        if (nr == m - 1 && nc == n - 1)
                        {
                            return pathLength + 1;
                        }
                        queue.Enqueue(new KeyValuePair<int, int>(nr, nc));
                    }
                }
            }
            return -1;
        }
    }
}
