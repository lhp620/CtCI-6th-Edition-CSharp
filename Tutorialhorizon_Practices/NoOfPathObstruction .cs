using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    class NoOfPathObstruction
    {
        public int count(int[][] arrA, int row, int col)
        {
            // base case
            // check if last cell is reached since after that only one path
            if (row == arrA.Length -1 && col == arrA.Length -1)
            {
                return 1;
            }

            int right = 0;
            int down = 0;

            if (row != arrA.Length -1 && arrA[row+1][col] != -1)
            {
                right = count(arrA, row + 1, col);
            }

            if (col != arrA.Length -1 && arrA[row][col +1] != -1)
            {
                down = count(arrA, row, col + 1);
            }

            return right + down;
        }

        public int countDP(int[][] arrA)
        {
            int[][] result = arrA;

            for (int i = 1;  i< result.Length; i++)
            {
                for (int j = i; j < result.Length; j++)
                {
                    if (result[i][j] != -1)
                    {
                        result[i][j] = 0;
                        if (result[i-1][j] >0)
                        {
                            result[i][j] += result[i - 1][j];
                        }
                        if (result[i][j-1] >0)
                        {
                            result[i][j] += result[i][j - 1];
                        }
                    }
                }
            }

            return result[arrA.Length - 1][arrA.Length - 1];

        }
    }
}
