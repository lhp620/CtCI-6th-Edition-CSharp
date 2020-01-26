using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    public class _17
    {
        private static String[] KEYS = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

        public static List<String> letterCombinations(String digits)
        {
            List<String> combinations = new List<string>();
            if (digits == null || digits.Length == 0)
            {
                return combinations;
            }
            doCombination(new StringBuilder(), combinations, digits);
            return combinations;
        }

        private static void doCombination(StringBuilder prefix, List<String> combinations, String digits)
        {
            if (prefix.Length == digits.Length)
            {
                combinations.Add(prefix.ToString());
                return;
            }
            int curDigits = digits[prefix.Length] - '0';
            String letters = KEYS[curDigits];
            foreach (char c in letters.ToCharArray())
            {
                prefix.Append(c);                         // 添加
                doCombination(prefix, combinations, digits);
                prefix.Remove(prefix.Length - 1, 1); // 删除
            }
        }
    }
}
