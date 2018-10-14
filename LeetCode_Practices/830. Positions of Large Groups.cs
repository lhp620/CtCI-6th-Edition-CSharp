using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _830
    {
        public IList<IList<int>> LargeGroupPositions(string S)
        {
            IList<IList<int>> answer = new List<IList<int>>();
            int initial = 0;
            int count = 1;
            for(int i = 1; i < S.ToCharArray().Length; i++)
            {
                if (S[i] == S[i-1])
                {
                    count++;
                }
                else
                {
                    // new char show up, calculate the previous char and count
                    if (count >= 3)
                    {
                        answer.Add(new List<int> { initial, initial + count - 1 });
                    }
                    initial = i;
                    count = 0;
                }
            }

            // catch the last one
            if (count >= 3)
            {
                answer.Add(new List<int> { initial, initial + count - 1 });
            }

            return answer;
        }
    }
}
