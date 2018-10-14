using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    public class RodCuttingRecursion
    {
        //https://algorithms.tutorialhorizon.com/dynamic-programming-rod-cutting-problem/
        public int profit(int[] value, int length)
        {
            if (length < 0) return 0;

            int max = -1;
            for (int i = 0; i < length; i++)
            {
                max = Math.Max(max, value[i] + profit(value, length - i - 1));
            }

            return max;
        }

        public int profitDP(int[] value, int length)
        {
            int[] solution = new int[length + 1];
            solution[0] = 0;

            for (int i = 1; i <= length; i++)
            {
                int max = -1;
                for (int j = 0; j < i; j++)
                {
                    max = Math.Max(max, value[j] + solution[i - j - 1]);
                }
            }

            return solution[length];
        }
    }
}
