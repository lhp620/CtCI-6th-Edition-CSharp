using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    class Dynamic_Programming___Coin_Change_Problem
    {
        // https://algorithms.tutorialhorizon.com/dynamic-programming-coin-change-problem/
        public static int total(int n, int[] v, int i)
        {
            if(n < 0)
            {
                return 0;
            }

            if (n==0)
            {
                return 1;
            }

            if (i == v.Length && n > 0)
            {
                return 0;
            }

            return total(n - v[i], v, i) + total(n, v, i + 1);  
        }

        public static int totalDynamic(int[] v, int amount)
        {
            int[][] solution = new int[v.Length + 1][];
            for(int i = 0; i < solution.Length; i++)
            {
                solution[i] = new int[amount + 1];
            }

            // if amount = 0, then just return empty set to make the change
            for (int i = 0; i<=v.Length; i++)
            {
                solution[i][0] = 1;
            }

            // if no coin given, 0 ways to change the amount
            for (int i = 0; i < amount; i++)
            {
                solution[0][i] = 0;
            }

            // now fill the rest of the matrix
            for (int i = 1; i <=v.Length; i++)
            {
                for(int j = 1; j<=amount; j++)
                {
                    // check if the coin value is less than the amount needed
                    if (v[i-1] <=j)
                    {
                        solution[i][j] = solution[i - 1][j] + solution[i][j - v[i - 1]];
                    }
                    else
                    {
                        solution[i][j] = solution[i - 1][j];
                    }
                }
            }
            return solution[v.Length][amount];
        }

    }
}
