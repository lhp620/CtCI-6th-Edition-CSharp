using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _917
    {
        public string ReverseOnlyLetters(string S)
        {
            int i = 0;
            int j = S.Length - 1;
			while (i < j)
            {
				if (char.IsLetter(S[i]) && char.IsLetter(S[j]))
                {
                    S = Swap(i, j, S);
                    i++;
                    j--;
                }
				else if (!char.IsLetter(S[i]))
                {
                    i++;
                }
				else if (!char.IsLetter(S[i]))
                {
                    j--;
                }
            }

            return S;
        }

		private string Swap(int i, int j, string S)
        {
            StringBuilder sb = new StringBuilder(S);
            char temp = sb[i];
            sb[i] = S[j];
            sb[j] = temp;

            return sb.ToString();
        }
    }
}
