using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _1071
    {
        public string GcdOfStrings(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;

			if (length1 < length2)
            {
                return GcdOfStrings(str2, str1);
            }
			else if (!str1.StartsWith(str2))
            {
                return string.Empty;
            }
			else if (str2 == string.Empty)
            {
                return str1;
            }
			else
            {
                return GcdOfStrings(str1.Substring(str2.Length), str2);
            }
        }
    }
}
