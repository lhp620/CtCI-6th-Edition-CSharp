using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _821
    {
        public int[] ShortestToChar(string S, char C)
        {
            int[] answer = new int[S.ToArray().Length];


            for(int i = 0; i < S.ToCharArray().Length; i++)
            {
                if (S[i] == C)
                {
                    answer[i] = 0;
                }
                else
                {
                    answer[i] = int.MaxValue;
                }
            }

            // handle the first C and last C
            // handle the first C and last C
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == 0)
                {
                    int index = i;
                    int distance = 1;
                    // fill the array with distance
                    while (index + 1 < answer.Length)
                    {
                        if (answer[index + 1] != 0)
                        {
                            answer[index + 1] = Math.Min(distance, answer[index + 1]);
                            index++;
                            distance++;
                        }
                        else
                        {
                            break;
                        }

                    }

                    index = i;
                    distance = 1;
                    while (index - 1 > 0)
                    {
                        if (answer[index - 1] != 0)
                        {
                            answer[index - 1] = Math.Min(distance, answer[index - 1]);
                            index--;
                            distance++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }


            return answer;
        }
    }
}
