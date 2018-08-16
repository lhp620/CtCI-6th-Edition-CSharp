using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    public class Dynamic_Programming
    {
        // CUT_ROD
        private static int[] p = new int[] { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };

        // Recursive
        public static int Cut_Rod(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            int q = int.MinValue;

            for (int i = 0; i <= n; i++)
            {
                q = Math.Max(q, p[i] + Cut_Rod(n - i));
            }

            return q;
        }

        // TOP Down
        public static int Memoized_Cut_Rod(int n)
        {
            int[] r = new int[n];
            for(int i = 0; i < n; i++)
            {
                r[i] = int.MinValue;
            }
            return Memoized_Cut_Rod_Aux(p, n, r);
        }

        private static int Memoized_Cut_Rod_Aux(int[] p, int n, int[] r)
        {
            if (r[n] >= 0) return r[n];

            int q;

            if (n == 0)
            {
                q = 0;
            }
            else
            {
                q = int.MinValue;
                for(int i = 1; i <= n; i++)
                {
                    q = Math.Max(q, p[i] + Memoized_Cut_Rod_Aux(p, n-i, r));
                }
            }
            r[n] = q;

            return q;
        }

        // Bottom Up
        public static int Bottom_Up_Cut_Rod(int n)
        {
            int[] r = new int[n + 1];
            r[0] = 0;

            for (int j = 1; j <= n; j++)
            {
                int q = int.MinValue;
                for (int i = 0; i <= j; i++)
                {
                    q = Math.Max(q, p[i] + r[j - i]);
                }
                r[j] = q;
            }

            return r[n];
        }
    }
}
