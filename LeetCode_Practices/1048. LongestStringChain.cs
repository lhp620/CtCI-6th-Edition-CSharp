using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _1048
    {
		public int LongestStrChain(string[] words)
        {
            Dictionary<string, int> dp = new Dictionary<string, int>();
            Array.Sort(words);

			foreach (var word in words)
            {
                int max = 0;
				for(int i = 0; i < word.Length; i++)
                {
                    string prev = word.Substring(0, i) + word.Substring(i + 1);
                }
                dp.Add(word, max);
            }

            int res = 0;
			foreach (int v in dp.Values)
            {
                res = Math.Max(res, v);
            }

            return res;
        }
    }
}
