using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter4
{
    class WordLadder
    {
        // https://www.geeksforgeeks.org/word-ladder-length-of-shortest-chain-to-reach-a-target-word/
        public int LadderLength(string start, string end, IList<string> wordList)
        {
            HashSet<string> dict = new HashSet<string>();

            foreach (var word in wordList)
            {
                dict.Add(word);
            }

            if (start.Equals(end))
            {
                return 1;
            }

            HashSet<string> hash = new HashSet<string>();
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(start);
            hash.Add(start);

            int length = 1;
            while(queue.Count > 0)
            {
                length++;
                int size = queue.Count;

                for (int i = 0; i< size; i++)
                {
                    string word = queue.Dequeue();
                    foreach (string nextWord in GetNextWords(word, dict))
                    {
                        if (hash.Contains(nextWord))
                        {
                            continue;
                        }
                        if (nextWord.Equals(end))
                        {
                            return length;
                        }

                        hash.Add(nextWord);
                        queue.Enqueue(nextWord);
                    }

                }
            }
            return 0;
        }

        private List<string> GetNextWords(string word, HashSet<string> dict)
        {
            List<string> nextWords = new List<string>();
            for (char c = 'a'; c <='z';c++)
            {
                for(int i = 0; i < word.Length; i++)
                {
                    if (c == word[i])
                    {
                        continue;
                    }

                    string nextWord = replace(word, i, c);
                    if (dict.Contains(nextWord))
                    {
                        nextWords.Add(nextWord);
                    }
                }
            }
            return nextWords;
        }

        private string replace(string s, int index, char c)
        {
            char[] chars = s.ToCharArray();
            chars[index] = c;
            return new string(chars);
        }
    }
}
