using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter8
{
    class First_Unique_Character_in_a_String
    {
        char[] count = new char[256];
        /// <summary>
        /// 1) Scan the string from left to right and construct the count array.
        /// 2) Again, scan the string from left to right and check for count of each
        /// character, if you find an element who's count is 1, return it.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FirstUniqueCharacterInAString(string s)
        {
            for (int i = 0; i < s.ToCharArray().Length; i++)
            {
                count[s[i]]++;
            }

            for (int j = 0; j< s.ToCharArray().Length; j++)
            {
                if (count[j] == 1)
                {
                    return j;
                }
            }

            return -1;
        }

        // the second way to have more info when scan the string.
        // use CountIndex to record the start index and count at the same time
        class CountIndex
        {
            public int count, index;
            public CountIndex(int index)
            {
                this.count = 1;
                this.index = index;
            }

            public void IncreaseCount()
            {
                this.count++;
            }
        }

        static Dictionary<char, CountIndex> hm = new Dictionary<char, CountIndex>();

        static void GetCharCountArray(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (hm.ContainsKey(str[i]))
                {
                    hm[str[i]].IncreaseCount();
                }
                else
                {
                    hm[str[i]] = new CountIndex(i);
                }
            }
        }

        public int FirstNonRepeat(string s)
        {
            GetCharCountArray(s);
            int result = int.MaxValue;

            foreach(var c in hm.Keys)
            {
                if(hm[c].count == 1 && result > hm[c].index)
                {
                    result = hm[c].index;
                }
            }

            return result == int.MaxValue ? -1 : result;
        }
    }
}
