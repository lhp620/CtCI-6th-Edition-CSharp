using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    //https://algorithms.tutorialhorizon.com/dynamic-programming-count-all-paths-from-top-left-to-bottom-right-of-a-mxn-matrix/
    class NoOfPaths
    {
        public int count(int[][] arrA, int row, int col)
        {
            // base case
            // check if last row or column is reached since after that only one path
            // is possible to reach to bottom right corner
            if (row==arrA.Length -1 || col == arrA.Length -1)
            {
                return 1;
            }

            return count(arrA, row + 1, col) + count(arrA, row, col + 1);
        }

        public int countDP(int[][] arrA)
        {
            int[][] result = new int[arrA.Length][];
            for(int i =0; i<result.Length; i++)
            {
                result[i] = new int[arrA.Length];
            }

            // base case
            result[0][0] = 1;

            // no of paths to reach in any cell in first row = 1
            for(int i = 0; i<result.Length; i++)
            {
                result[0][i] = 1;
            }

            for(int i = 0; i< result.Length; i++)
            {
                result[i][0] = 1;
            }

            for(int i = 1; i < result.Length; i++)
            {
                for(int j = 1; j < result.Length; j++)
                {
                    result[i][j] = result[i - 1][j] + result[i][j - 1];
                }
            }

            return result[arrA.Length - 1][arrA.Length - 1];
        }
    }
}
