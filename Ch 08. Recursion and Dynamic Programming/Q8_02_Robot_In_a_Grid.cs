using System;
using System.Collections.Generic;
using System.Text;

namespace Ch_08._Recursion_and_Dynamic_Programming
{
    class Q8_02_Robot_In_a_Grid
    {
        List<Point> GetPath(bool[][] maze)
        {
            if (maze == null || maze.Length == 0) return null;
            List<Point> path = new List<Point>();
            if(GetPath(maze, maze.Length -1, maze[0].Length -1, path))
            {
                return path;
            }
            return null;
        }

        public bool GetPath(bool[][] maze, int row, int col, List<Point> path)
        {
            if (col < 0 || row < 0 || !maze[row][col])
            {
                return false;
            }

            bool IsAtOrigin = (row == 0) && (col == 0);

            // if there is a pth from the start to here, add my location
            if (IsAtOrigin || GetPath(maze, row, col-1, path) || GetPath(maze, row -1, col, path))
            {
                Point p = new Point(row, col);
                path.Add(p);
                return true;
            }

            return false;
        }

        public List<Point> GetPath_d(bool[][] maze)
        {
            if (maze == null || maze.Length == 0) return null;
            List<Point> path = new List<Point>();
            HashSet<Point> failedPoints = new HashSet<Point>();

            if (GetPath_d(maze, maze.Length - 1, maze[0].Length - 1, path, failedPoints));
            {
                return path;
            }
            return null;
        }

        private bool GetPath_d(bool[][] maze, int row, int col, List<Point> path, HashSet<Point> failedPoints)
        {
            if (col < 0 || row < 0 || !maze[row][col])
            {
                return false;
            }

            Point p = new Point(row, col);

            if (failedPoints.Contains(p))
            {
                return false;
            }

            bool IsAtOrigin = (row == 0) && (col == 0);

            // if there is a path from start to my current location, add my location
            if (IsAtOrigin || GetPath_d(maze, row, col -1, path ,failedPoints) || GetPath_d(maze, row -1, col, path, failedPoints))
            {
                path.Add(p);
                return true;
            }

            failedPoints.Add(p);
            return false;
        }
    }

    internal class Point
    {
        private int row;
        private int col;

        public Point(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}
