using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class Boats_to_Save_People
    {
        //https://leetcode.com/problems/boats-to-save-people/solution/
        public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);
            int i = 0, j = people.Length - 1;
            int answer = 0;

            while (i <= j)
            {
                answer++;
                if (people[i] + people[j] <= limit)
                {
                    i++;
                }
                j--;
            }

            return answer;
        }
    }
}
