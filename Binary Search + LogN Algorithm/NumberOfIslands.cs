using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter4
{
    // https://leetcode.com/problems/number-of-islands/
    class NumberOfIslands
    {
        public class Coordinate
        {
            public int x, y;
            public Coordinate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public int numIslands(bool[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }

            int n = grid.Length;
            int m = grid[0].Length;
            int islands = 0;


            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (grid[i][j])
                    {
                        markByBFS(grid, i, j);
                        islands++;
                    }
                }
            }

            return islands;
        }

        private void markByBFS(bool[][]grid, int x, int y)
        {
            int[] directionX = { 0, 1, -1, 0 };
            int[] directionY = { 1, 0, 0, -1 };

            Queue<Coordinate> queue = new Queue<Coordinate>();
            queue.Enqueue(new Coordinate(x, y));
            grid[x][y] = false;

            while(queue.Count > 0)
            {
                Coordinate coor = queue.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    Coordinate adj = new Coordinate(coor.x + directionX[i], coor.y + directionY[i]);
                    if(!inBound(adj, grid))
                    {
                        continue;
                    }
                    if (grid[adj.x][adj.y])
                    {
                        grid[adj.x][adj.y] = false;
                        queue.Enqueue(adj);
                    }
                }
            }
        }

        private bool inBound(Coordinate adj, bool[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            return adj.x >= 0 && adj.x < n && adj.y >=0 && adj.y < m;
        }
    }
}
