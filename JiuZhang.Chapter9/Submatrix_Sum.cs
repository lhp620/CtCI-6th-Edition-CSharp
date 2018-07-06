using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter9
{
    class Submatrix_Sum
    {
        public int[][] SubMatrixSum(int[][] matrix)
        {
            int[][] result = new int[2][];

            int M = matrix.Length;
            if (M == 0) return result;
            int N = matrix[0].Length;
            if (N == 0) return result;

            int[][] sum = new int[M + 1][];
            for (int j = 0; j <= N; j++) sum[0][j] = 0;
            for (int i = 0; i <= M; i++) sum[i][0] = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sum[i + 1][j + 1] = matrix[i][j] + sum[i + 1][j] + sum[i][j + 1] - sum[i][j];
                }
            }

            for (int l = 0; l < M; l++)
            {
                for (int h = l + 1; h <= M; ++h)
                {
                    Dictionary<int, int> map = new Dictionary<int, int>();
                    for (int j = 0; j <= N; ++j)
                    {
                        int diff = sum[h][j] - sum[l][j];
                        if (map.ContainsKey(diff))
                        {
                            int k = map[diff];
                            result[0][0] = l; result[0][1] = k;
                            result[1][0] = h - 1; result[1][1] = j - 1;
                            return result;
                        }
                        else
                        {
                            map[diff] = j;
                        }
                    }
                }
            }
            return result;
        }
    }
}
