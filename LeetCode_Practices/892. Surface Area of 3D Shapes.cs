using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _892
    {
        // https://leetcode.com/problems/surface-area-of-3d-shapes/solution/
        public int SurfaceArea(int[][] grid)
        {
            // we need calculate the 6 sides of the grid to get the total suface
            // the top and the bottom
            int noneZero = 0;

            // for surround 4 sides 
            int xz = 0, yz = 0;
            int[] xzMax = new int[grid.Length];
            int[] yzMax = new int[grid[0].Length];

            for (int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[0].Length; j++)
                {
                    xzMax[i] = Math.Max(xzMax[i], grid[i][j]);
                    if (grid[i][j] != 0)
                    {
                        noneZero++;
                    }
                }
            }
            for (int i = 0; i < grid[0].Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    yzMax[i] = Math.Max(yzMax[i], grid[j][i]);
                }
            }

            foreach(int i in xzMax)
            {
                xz += i;
            }

            foreach (int i in yzMax)
            {
                yz += i;
            }

            return noneZero * 2 + xz*2 + yz*2;
        }
    }
}
