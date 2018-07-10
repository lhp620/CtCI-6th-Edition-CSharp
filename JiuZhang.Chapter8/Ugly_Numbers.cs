using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter8
{
    class Ugly_Numbers
    {
        // this function divides a by greatest divisible power of b
        static int MaxDivide(int a, int b)
        {
            while (a%b ==0)
            {
                a = a / b;
            }

            return a;
        }

        static int IsUgly(int no)
        {
            no = MaxDivide(no, 2);
            no = MaxDivide(no, 3);
            no = MaxDivide(no, 5);

            return (no == 1) ? 1 : 0;
        }

        static int GetNthUglyNo(int n)
        {
            int i = 1;
            int count = 1;
            while(n>count)
            {
                i++;
                if (IsUgly(i) ==1)
                {
                    count++;
                }
            }

            return i;
        }
    }
}
