using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter2
{
    class Knight_Shortest_Path
    {
        public class Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        int n, m; // size of the chessboard
        int[] deltaX = { 1, 1, 2, 2, -1, -1, -2, -2 };
        int[] deltaY = { 2, -2, 1, -1, 2, -2, 1, -1 };
        /**
         * @param grid a chessboard included 0 (false) and 1 (true)
         * @param source, destination a point
         * @return the shortest path 
         */
        public int shortestPath(bool[][] grid, Point source, Point destination)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            {
                return -1;
            }

            n = grid.Length;
            m = grid[0].Length;

            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(source);

            int steps = 0;
            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    Point point = queue.Dequeue();
                    if (point.x == destination.x && point.y == destination.y)
                    {
                        return steps;
                    }

                    for (int direction = 0; direction < 8; direction++)
                    {
                        Point nextPoint = new Point(
                            point.x + deltaX[direction],
                            point.y + deltaY[direction]
                        );

                        if (!inBound(nextPoint, grid))
                        {
                            continue;
                        }

                        queue.Enqueue(nextPoint);
                        // mark the point not accessible
                        grid[nextPoint.x][nextPoint.y] = true;
                    }
                }
                steps++;
            }

            return -1;
        }

        private bool inBound(Point point, bool[][] grid)
        {
            if (point.x < 0 || point.x >= n)
            {
                return false;
            }
            if (point.y < 0 || point.y >= m)
            {
                return false;
            }
            return (grid[point.x][point.y] == false);
        }
    }
}
