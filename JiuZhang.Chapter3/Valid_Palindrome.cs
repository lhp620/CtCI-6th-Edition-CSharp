using System;
using System.Collections.Generic;
using System.Text;

namespace JiuZhang.Chapter3
{
    public class Valid_Palindrome
    {
        public static bool ValidPalindrome(string s)
        {
            if (s == null || s.Length == 0)
            {
                return true;
            }

            int start = 0;
            int end = s.Length - 1;
            while (start < end)
            {
                // skip the invalid char for start
                while (start < s.Length && !IsValidChar(s[start]))
                {
                    start++;
                }

                // skip the invalid char for end
                while(end > 0 && !IsValidChar(s[end]))
                {
                    end--;
                }

                if (Char.ToLower(s[start]) != Char.ToLower(s[end]))
                {
                    break;
                }
                else
                {
                    start++;
                    end--;
                }
            }

            return end <= start;
        }

        private static bool IsValidChar(char v)
        {
            return Char.IsDigit(v) || char.IsLetter(v);
        }
    }
}
