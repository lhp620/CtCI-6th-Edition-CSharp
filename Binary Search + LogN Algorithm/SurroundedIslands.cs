using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter2
{
    class SurroundedIslands
    {
        public char[][] Board;
        public int N;
        public int M;

        public void Solve(char[][] board)
        {
            int m = board.Length;
            int n = board[0].Length;
            this.Board = board;
            this.N = n;
            this.M = m;

            // check the cell left and right border, if the cell value is x, mark it as G (good), which will not be filpped to o later
            for (int y = 0; y < m; y++)
            {
                dfs(0, y);
                dfs(n - 1, y);
            }

            // check the cell top and bottom border, if the cell value is x, mark it as G (good), which will not be filpped to o later
            for (int x = 0; x < n; x++)
            {
                dfs(x, 0);
                dfs(x, m-1);
            }

            Dictionary<char, char> d = new Dictionary<char, char>();
            // if it is G, which is the o connected to the border, change it back to o
            // if it is o, which is the o surrounded by x, change it to x
            // if it is x, not change
            d.Add('G', 'o');
            d.Add('o', 'x');
            d.Add('x', 'x');

            for(int y = 0; y < m; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    board[y][x] = d[board[y][x]];
                }
            }
        }

        private void dfs(int x, int y)
        {
            if (x < 0 || x >= N || y < 0 || y >= M || Board[x][y] == 'o')
                return;

            Board[y][x] = 'G';
            dfs(x - 1, y);
            dfs(x + 1, y);
            dfs(x, y + 1);
            dfs(x, y - 1);
        }

    }
}
