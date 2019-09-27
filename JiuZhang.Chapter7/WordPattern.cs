using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    class WordPattern
    {
        public bool wordPattern(String pattern, String str)
        {
            String[] words = str.Split(' ');
            if (words.Length != pattern.Length)
                return false;
            Dictionary<string, int> index = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; ++i)
            {
                index.Add(pattern[i].ToString(), i);
                try
                {
                    index.Add(words[i], i);
                    return false;
                }
                catch (Exception)
                {
                }
            }
            return true;
        }
    }
}
