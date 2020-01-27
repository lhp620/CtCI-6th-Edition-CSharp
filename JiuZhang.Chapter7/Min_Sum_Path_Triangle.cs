using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    class Min_Sum_Path_Triangle
    {
        // https://leetcode.com/problems/triangle/
        // https://leetcode.com/problems/triangle/discuss/38730/DP-Solution-for-Triangle
        public int MinSumPathTriangle(List<List<int>> grid)
        {
            // define the table for dp
            int[] table = new int[grid[grid.Count - 1].Count];

            // bottom up: fill the table with the bottom values
            for(int i = 0; i < grid[grid.Count - 1].Count; i++)
            {
                table[i] = grid[grid.Count - 1][i];
            }

            // from the last but two row and bottom up 
            // search each item in this row and find the min Sum
            for (int i = grid.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j < grid[i].Count; j++)
                {
                    table[j] = grid[i][j] + Math.Min(table[j], table[j + 1]);
                }
            }

            return table[0];
        }
    }
}
