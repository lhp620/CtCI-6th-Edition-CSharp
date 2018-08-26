using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class Decoded_String_at_Index
    {
        public string DecodeAtIndex(string S, int K)
        {
            long size = 0;
            int N = S.Length;

            // find size without repeat after expanding S
            for (int i = 0; i < N; i++)
            {
                char c = S[i];
                if (Char.IsDigit(c))
                {
                    size *= c - '0';
                }
                else
                { size++; }
            }

            for (int i = N-1; i>=0;--i)
            {
                char c = S[i];

                K = (int)(K % size);
                if (K==0 &&char.IsLetter(c))
                {
                    return char.ToString(c);
                }

                if (char.IsDigit(c))
                {
                    size /= c - '0';
                }
                else
                {
                    size--;
                }
            }

            throw null;
        }
    }
}
