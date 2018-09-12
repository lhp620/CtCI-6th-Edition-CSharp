using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _890
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            List<string> ans = new List<string>();
            foreach (string word in words)
            {
                if (match(word, pattern))
                {
                    ans.Add(word);
                }
            }

            return ans;
        }

        private bool match(string word, string pattern)
        {
            Dictionary<char, char> d1 = new Dictionary<char, char>();
            Dictionary<char, char> d2 = new Dictionary<char, char>();

            for (int i = 0; i < word.Length; i++)
            {
                char w = word[i];
                char p = pattern[i];

                if (!d1.ContainsKey(w))
                {
                    d1[w] = p;
                }
                if (!d2.ContainsKey(p))
                {
                    d2[p] = w;
                }
                if (d1[w] != p || d2[p] != w)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
