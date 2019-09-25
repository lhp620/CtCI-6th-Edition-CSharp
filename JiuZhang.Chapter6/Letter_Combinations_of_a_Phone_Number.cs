using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    class Letter_Combinations_of_a_Phone_Number
    {
        public List<string> letterCombinations(String digits)
        {
            List<String> result = new List<string>();

            if (string.IsNullOrEmpty(digits))
            {
                return result;
            }

            Dictionary<char, char[]> map = new Dictionary<char, char[]>();
            map.Add('2', new char[] { 'a', 'b', 'c' });
            map.Add('3', new char[] { 'd', 'e', 'f' });
            map.Add('4', new char[] { 'g', 'h', 'i' });
            map.Add('5', new char[] { 'j', 'k', 'l' });
            map.Add('6', new char[] { 'm', 'n', 'o' });
            map.Add('7', new char[] { 'p', 'q', 'r', 's' });
            map.Add('8', new char[] { 't', 'u', 'v' });
            map.Add('9', new char[] { 'w', 'x', 'y', 'z' });

            StringBuilder sb = new StringBuilder();
            helper(map, digits, sb, result);

            return result;
        }

        private void helper(Dictionary<char, char[]> map, String digits,
            StringBuilder sb, List<String> result)
        {
            if (sb.Length == digits.Length)
            {
                result.Add(sb.ToString());
                return;
            }

            foreach (char c in map[digits[sb.Length]])
            {
                sb.Append(c);
                helper(map, digits, sb, result);
                sb.Remove(sb.Length - 1, 1);
            }
        }
    }
}
