using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class Projection_Area_of_3D_Shapes
    {
        public int ProjectionArea(int[][] grid)
        {
            // calculate from top
            int x = grid.Length;
            int y = grid[0].Length;

            int top = 0, front = 0, side = 0;

            for (int i = 0; i < x; i++)
            {
                int temp_y = 0;
                for (int j = 0; j < y; j++)
                {
                    if (grid[i][j] != 0)
                    {
                        top++;
                    }

                    // find the largest y
                    temp_y = Math.Max(temp_y, grid[i][j]);
                }
                side += temp_y;
            }
            
            for (int j = 0; j < y; j++)
            {
                int temp_x = 0;
                for (int i = 0; i < x; i++)
                {
                    temp_x = Math.Max(temp_x, grid[i][j]);
                }
                front += temp_x;
            }

            return top + front + side;
        }
    }
}
