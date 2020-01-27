using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.Backtracking
{
    // https://leetcode.com/problems/word-search/
    class _79
    {
        private static int[][] direction = new int[][]{ new int[]{ 1, 0 }, new int[]{ -1, 0 }, new int[]{ 0, 1 }, new int[]{ 0, -1 } };
        private int m;
        private int n;

        public bool exist(char[][] board, String word)
        {
            if (word == null || word.Length == 0)
            {
                return true;
            }
            if (board == null || board.Length == 0 || board[0].Length == 0)
            {
                return false;
            }

            m = board.Length;
            n = board[0].Length;
            bool[][] hasVisited = new bool[m][];
            for(int i = 0; i < m; i++)
            {
                hasVisited[i] = new bool[n];
            }

            for (int r = 0; r < m; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (backtracking(0, r, c, hasVisited, board, word))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool backtracking(int curLen, int r, int c, bool[][] visited, Char[][] board, String word)
        {
            if (curLen == word.Length)
            {
                return true;
            }
            if (r < 0 || r >= m || c < 0 || c >= n
                    || board[r][c] != word[curLen] || visited[r][c])
            {
                return false;
            }

            visited[r][c] = true;

            foreach (int[] d in direction)
            {
                if (backtracking(curLen + 1, r + d[0], c + d[1], visited, board, word))
                {
                    return true;
                }
            }

            visited[r][c] = false;

            return false;
        }
    }
}
