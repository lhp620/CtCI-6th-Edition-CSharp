using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    // https://algorithms.tutorialhorizon.com/dynamic-programming-coin-in-a-line-game-problem/
    class CoinGame
    {
        public static int solve(int[] A)
        {
            int[][] MV = new int[A.Length][];
            for(int i = 0; i < A.Length; i++)
            {
                MV[i] = new int[A.Length];
            }

            for(int interval = 0; interval <A.Length; interval++)
            {
                for (int i = 0, j = interval; j<A.Length; i++, j++)
                {
                    // a = MV(i+2, j)   - Alice choose i Bob chooses i+1
                    // b = MV(i+1, j-1) - Alice choose i, Bob choose j or Alice choose j, Bob chooses i
                    // c = MV(i, j-2) - Alice choose j, Bob choose j-1
                    int a, b, c;
                    if (i+2 <=j)
                    {
                        a = MV[i + 2][j];
                    }
                    else
                    {
                        a = 0;
                    }

                    if (i+1 <= j-1)
                    {
                        b = MV[i + 1][j - 1];
                    }
                    else
                    {
                        b = 0;
                    }

                    if (i <= j-2)
                    {
                        c = MV[i][j - 2];
                    }
                    else
                    {
                        c = 0;
                    }

                    MV[i][j] = Math.Max(A[i] + Math.Min(a, b), A[j] + Math.Min(b, c));
                }
            }

            return MV[0][A.Length - 1];
        }
    }
}
