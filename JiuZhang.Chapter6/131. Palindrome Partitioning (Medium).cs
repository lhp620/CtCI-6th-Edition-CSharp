using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    class _131
    {
        //https://leetcode.com/problems/palindrome-partitioning/description/
        public List<List<String>> partition(String s)
        {
            List<List<String>> partitions = new List<List<string>>();
            List<String> tempPartition = new List<string>();
            doPartition(s, partitions, tempPartition);
            return partitions;
        }

        private void doPartition(String s, List<List<String>> partitions, List<String> tempPartition)
        {
            if (s.Length == 0)
            {
                partitions.Add(new List<string>(tempPartition));
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (isPalindrome(s, 0, i))
                {
                    tempPartition.Add(s.Substring(0, i + 1));
                    doPartition(s.Substring(i + 1), partitions, tempPartition);
                    tempPartition.RemoveAt(tempPartition.Count - 1);
                }
            }
        }

        private bool isPalindrome(String s, int begin, int end)
        {
            while (begin < end)
            {
                if (s[begin++] != s[end--])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
