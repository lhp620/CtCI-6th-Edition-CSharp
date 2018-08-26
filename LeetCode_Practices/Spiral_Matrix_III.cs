using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class Spiral_Matrix_III
    {
        // https://leetcode.com/problems/spiral-matrix-iii/solution/
        public int[][] SpiralMatrixIII(int R, int C, int r0, int c0)
        {
            int[] dr = new int[] { 0, 1, 0, -1 };
            int[] dc = new int[] { 1, 0, -1, 0 };

            int[][] answer = new int[R * C][];
            for(int i = 0; i < answer.Length; i++)
            {
                answer[i] = new int[2];
            }

            int t = 0;
            answer[t++] = new int[] { r0, c0 };
            if (R * C == 1) return answer;

            for (int k = 1; k < 2*(R+C); k+=2)
            {
                // direction index
                for (int i = 0; i < 4; i++)
                {
                    // number of steps in this direction
                    int dk = k + (i / 2);
                    for (int j = 0; j <dk; ++j)
                    {
                        // step in the i-th direction
                        r0 += dr[i];
                        c0 += dc[i];
                        if (0<=r0 && r0<R &&0<=c0&&c0<C)
                        {
                            answer[t++] = new int[] { r0, c0 };
                            if (t==R*C)
                            {
                                return answer;
                            }
                        }
                    }

                }
            }

            throw null;
        }
    }
}
