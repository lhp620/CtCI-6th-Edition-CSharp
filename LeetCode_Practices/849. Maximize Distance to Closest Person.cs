using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _849
    {
        public int MaxDistToClosest(int[] seats)
        {
            int answer = int.MinValue;
            for(int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 0)
                {
                    int[] temp_seats = seats;
                    temp_seats[i] = 1;
                    int temp = MaxDistToClosestTemp(temp_seats, i);
                    temp_seats[i] = 0;
                    answer = Math.Max(answer, temp);
                }
            }

            return answer;
        }

        private int MaxDistToClosestTemp(int[] temp_seats, int i)
        {
            // to the left people
            int left_distance = 1;
            int left = i;
            while (left - 1 > 0)
            {
                if (temp_seats[left - 1] == 1)
                {
                    break;
                }
                else
                {
                    left_distance++;
                }
                left--;
            }
            if (i == 0) left_distance = int.MaxValue;

            // to the right people
            int right_distance = 1;
            int right = i;
            while(right + 1 < temp_seats.Length)
            {
                if (temp_seats[right + 1] == 1)
                {
                    break;
                }
                else
                {
                    right_distance++;
                }
                right++;
            }
            if (i == temp_seats.Length - 1) right_distance = int.MaxValue;

            return Math.Min(left_distance, right_distance);
        }
    }
}
