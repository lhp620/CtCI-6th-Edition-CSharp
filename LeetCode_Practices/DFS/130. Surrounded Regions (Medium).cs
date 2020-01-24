using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.DFS
{
    class _130
    {
        private int[][] direction = new int[][]{ new int[]{ 0, 1 }, new int[]{ 0, -1 }, new int[]{ 1, 0 }, new int[]{ -1, 0 } };
        private int m, n;

        public void solve(char[][] board)
        {
            if (board == null || board.Length == 0)
            {
                return;
            }

            m = board.Length;
            n = board[0].Length;

            for (int i = 0; i < m; i++)
            {
                dfs(board, i, 0);
                dfs(board, i, n - 1);
            }
            for (int i = 0; i < n; i++)
            {
                dfs(board, 0, i);
                dfs(board, m - 1, i);
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i][j] == 'T')
                    {
                        board[i][j] = 'O';
                    }
                    else if (board[i][j] == 'O')
                    {
                        board[i][j] = 'X';
                    }
                }
            }
        }

        private void dfs(char[][] board, int r, int c)
        {
            if (r < 0 || r >= m || c < 0 || c >= n || board[r][c] != 'O')
            {
                return;
            }
            board[r][c] = 'T';
            foreach (int[] d in direction)
            {
                dfs(board, r + d[0], c + d[1]);
            }
        }
    }
}
