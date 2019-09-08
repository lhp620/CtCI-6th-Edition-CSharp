using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _1047
    {
        public string RemoveDuplicates(string S)
        {
            if (S.Length == 0 || S.Length ==1)
            {
                return S;
            }

            int firstPoint = 0;
            int secondPoint = 1;

            while(firstPoint < secondPoint && firstPoint < S.Length && secondPoint < S.Length)
            {
                if (S[firstPoint] == S[secondPoint])
                {
                    S = S.Remove(firstPoint, 1);
                    S = S.Remove(secondPoint - 1, 1);

                    // reset first and second point
                    firstPoint = 0;
                    secondPoint = 1;
                }
                else
                {
                    firstPoint++;
                    secondPoint++;
                }
            }

            return S;
        }
    }
}
