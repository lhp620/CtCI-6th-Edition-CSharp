using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter1
{
    public class Implement_strStr
    {
        /// <summary>
        /// Implement strStr().
        ///Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
        /// </summary>
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(haystack) || string.IsNullOrEmpty(needle))
                return -1;
            for(int i = 0; i < haystack.Length; i++)
            {
                if (haystack.Substring(i, haystack.Length - i > needle.Length ? needle.Length : haystack.Length - i) == needle)
                {
                    return i;
                    break;
                }
            }

            return -1;
        }

        public int Strstr2(string haystack, string needle)
        {
            for (int i = 0; ; i++)
            {
                for (int j = 0; ; j++)
                {
                    if (j == needle.Length) return i;
                    if (i + j == haystack.Length) return -1;
                    if (needle[j] != haystack[i + j]) break;
                }
            }
        }
    }
}
