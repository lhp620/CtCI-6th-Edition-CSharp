using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _875
    {
        public int MinEatingSpeed(int[] piles, int H)
        {
            int low = 1;
            int high = 1000000000;

            while( low < high)
            {
                int middle = (high + low) / 2;
                if(NeedHours(piles, middle) > H)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle;
                }
            }

            return low;
            
        }

        private double NeedHours(int[] piles, int eatPerHour)
        {
            double result = 0;
            foreach(int p in piles)
            {
                if (Math.Truncate((double)(p / eatPerHour)) == 0)
                {
                    result++;
                }
                else
                {
                    result += p / eatPerHour;
                    if (p% eatPerHour != 0)
                    {
                        result ++;
                    }
                }
            }

            return result;
        }
    }
}
