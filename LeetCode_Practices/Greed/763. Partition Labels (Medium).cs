using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices.Greed
{
    class _763
    {
        public List<int> partitionLabels(String S)
        {
            int[] lastIndexsOfChar = new int[26];
            for (int i = 0; i < S.Length; i++)
            {
                lastIndexsOfChar[char2Index(S[i])] = i;
            }
            List<int> partitions = new List<int>();
            int firstIndex = 0;
            while (firstIndex < S.Length)
            {
                int lastIndex = firstIndex;
                for (int i = firstIndex; i < S.Length && i <= lastIndex; i++)
                {
                    int index = lastIndexsOfChar[char2Index(S[i])];
                    if (index > lastIndex)
                    {
                        lastIndex = index;
                    }
                }
                partitions.Add(lastIndex - firstIndex + 1);
                firstIndex = lastIndex + 1;
            }
            return partitions;
        }

        private int char2Index(char c)
        {
            return c - 'a';
        }
    }
}
