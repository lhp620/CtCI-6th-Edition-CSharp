using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    class Word_Search
    {
        //https://leetcode.com/problems/word-search/
        public bool WordSearch(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
                for(int j = 0; j < board[0].Length; j++)
                {
                    if (SearchHelper(i, j, 0, board, word))
                    {
                        return true;
                    }
                }
            return false;
        }

        private bool SearchHelper(int x, int y, int index, char[][] board, string word)
        {
            if (OutOfBoard(x, y, board)) return false;
            if (board[x][y] != word.ToCharArray()[index]) return false;
            if (index == word.ToCharArray().Length - 1) return false;

            // mark the current one as the '0', to not selet it again in the dfs
            char temp = board[x][y];
            board[x][y] = '0';

            bool found = SearchHelper(x - 1, y, index + 1, board, word) ||
                         SearchHelper(x + 1, y, index + 1, board, word) ||
                         SearchHelper(x, y + 1, index + 1, board, word) ||
                         SearchHelper(x, y - 1, index + 1, board, word);
            // update the board back
            board[x][y] = temp;

            return found;
        }

        private bool OutOfBoard (int x, int y, char[][] board)
        {
            if (x < 0 || x > board.Length - 1) return false;
            if (y < 0 || y > board[0].Length - 1) return false;
            return true;
        }
    }
}
