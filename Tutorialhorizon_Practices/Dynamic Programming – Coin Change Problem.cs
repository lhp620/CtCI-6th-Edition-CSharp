using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    class Dynamic_Programming___Coin_Change_Problem
    {
        // https://algorithms.tutorialhorizon.com/dynamic-programming-coin-change-problem/
        public static int total(int n, int[] v, int i)
        {
            if(n < 0)
            {
                return 0;
            }

            if (n==0)
            {
                return 1;
            }

            if (i == v.Length && n > 0)
            {
                return 0;
            }

            return total(n - v[i], v, i) + total(n, v, i + 1);  
        }
    }
}
