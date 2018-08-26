using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    // https://leetcode.com/problems/uncommon-words-from-two-sentences/
    public class Uncommon_Words_from_Two_Sentences
    {
        public string[] UncommonFromSentences(string A, string B)
        {
            Dictionary<string, int> dic_a = new Dictionary<string, int>();
            Dictionary<string, int> dic_b = new Dictionary<string, int>();

            InsertIntoDictionary(dic_a, A);
            InsertIntoDictionary(dic_b, B);

            List<string> uca = UncommonWordsInSingleSentence(dic_a);
            List<string> ucb = UncommonWordsInSingleSentence(dic_b);

            List<string> results = new List<string>();

            foreach (var s in uca)
            {
                if (!dic_b.Keys.Contains(s))
                {
                    results.Add(s);
                }
            }

            foreach (var s in ucb)
            {
                if (!dic_a.Keys.Contains(s))
                {
                    results.Add(s);
                }
            }

            return results.ToArray();
        }

        private List<string> UncommonWordsInSingleSentence(Dictionary<string, int> dic)
        {
            List<string> results = new List<string>();

            foreach (var s in dic.Keys)
            {
                if (dic[s] == 1)
                {
                    results.Add(s);
                }
            }

            return results;
        }

        private void InsertIntoDictionary(Dictionary<string, int> d, string s)
        {
            foreach (string a in s.Split(' '))
            {
                if (d.Keys.Contains(a))
                {
                    d[a]++;
                }
                else
                {
                    d.Add(a, 1);
                }
            }
        }
    }
}
