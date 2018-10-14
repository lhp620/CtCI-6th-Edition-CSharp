using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    class Minimum_Numbers_are_Required_Whose_Square_Sum_is_Equal_To_a_Given_Number
    {
        public void solve (int n)
        {
            int options = (int)Math.Sqrt(n);
            // call recursion 
            int answer = solveRecursively(n, options);
            int answerDP = solveDP(n, options);
        }

        private int solveDP(int n, int options)
        {
            // Minimum numbers required whose sum is = n
            int[] MN = new int[n + 1];
            MN[0] = 0;

            int[] NUM = new int[options + 1];
            for (int number =1; number <=n; number++)
            {
                // reset the NUM[] for new i
                for (int j=0;j<=options; j++)
                {
                    NUM[j] = 0;
                }

                // now try every option one by one and fill the solution in NUM[]
                for (int j = 1; j <= options; j++)
                {
                    // check the criteria
                    if (j*j <= number)
                    {
                        // select the number, add 1 to the solution of num - j*j
                        NUM[j] = MN[number - j * j] + 1;
                    }
                }

                // now choose the optimal solution from NUM[]
                MN[number] = -1;

                for (int j = 1; j < NUM.Length; j++)
                {
                    if (NUM[j] > 0 && (MN[number] == -1 || MN[number] > NUM[j]))
                    {
                        MN[number] = NUM[j];
                    }
                }
            }

            return MN[n];
        }

        private int solveRecursively(int n, int options)
        {
            if (n < 0)
            {
                return 0;
            }

            int min = solveRecursively(n - 1 * 1, options);

            for (int i = 2; i <= options; i++)
            {
                if (n>i*i)
                {
                    min = Math.Min(min, solveRecursively(n - i * i, options));
                }
            }

            return min + 1;
        }
    }
}
