using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Charpter1
{
    class LongestPalindromicSubstring
    {
        // emulator  O(n^2)
        public String longestPalindrome(String s)
        {
            if (s == null || s.Length == 0)
            {
                return "";
            }

            int start = 0, len = 0, longest = 0;
            for (int i = 0; i < s.Length; i++)
            {
                len = findLongestPalindromeFrom(s, i, i);
                if (len > longest)
                {
                    longest = len;
                    start = i - len / 2;
                }

                len = findLongestPalindromeFrom(s, i, i + 1);
                if (len > longest)
                {
                    longest = len;
                    start = i - len / 2 + 1;
                }
            }

            return s.Substring(start, start + longest);
        }

        private int findLongestPalindromeFrom(String s, int left, int right)
        {
            int len = 0;
            while (left >= 0 && right < s.Length)
            {
                if (s[left] != s[right])
                {
                    break;
                }
                len += left == right ? 1 : 2;
                left--;
                right++;
            }

            return len;
        }

        // Dynamic O(n^2) O(n^2)
        public String longestPalindrome2(String s)
        {
            if (s == null || s.Length == 0)
            {
                return "";
            }

            int n = s.Length;
            bool[][] isPalindrome = new bool[n][];
            for(int i = 0; i < n; i++)
            {
                isPalindrome[i] = new bool[n];
            }

            int longest = 1, start = 0;
            for (int i = 0; i < n; i++)
            {
                isPalindrome[i][i] = true;
            }
            for (int i = 0; i < n - 1; i++)
            {
                isPalindrome[i][i + 1] = s[i] == s[i + 1];
                if (isPalindrome[i][i + 1])
                {
                    start = i;
                    longest = 2;
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = i + 2; j < n; j++)
                {
                    isPalindrome[i][j] = isPalindrome[i + 1][j - 1] &&
                        s[i] == s[j];

                    if (isPalindrome[i][j] && j - i + 1 > longest)
                    {
                        start = i;
                        longest = j - i + 1;
                    }
                }
            }

            return s.Substring(start, start + longest);
        }
    }
}
