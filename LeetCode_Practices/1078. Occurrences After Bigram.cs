using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _1078
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            var wordList = text.Split(' ');
            var length = wordList.Length;
            List<string> result = new List<string>();

            for(int i = 0; i < length; i++)
            {
                if (wordList[i] == first)
                {
                    if (i+1 < length && (wordList[i+1] == second))
                    {
                        if (i+2 < length)
                        {
                            result.Add(wordList[i + 2]);
                        }
                    }
                }
            }

            return result.ToArray();
        }
    }
}
