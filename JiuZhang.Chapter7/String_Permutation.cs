using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    public class String_Permutation
    {
        public static void Permutate(string s, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(s);
            }
            else
            {
                for (int i = l; i < r; i++)
                {
                    s = Swap(s, l, i);
                    Permutate(s, l + 1, r);
                    s = Swap(s, l, i);
                }
            }
        }

        private static string Swap(string s, int l, int r)
        {
            char temp;
            char[] charArray = s.ToCharArray();
            temp = charArray[l];
            charArray[l] = charArray[r];
            charArray[r] = temp;

            return charArray.ToString();
        }
    }
}
