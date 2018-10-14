using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _860
    {
        public bool LemonadeChange(int[] bills)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic[5] = 0;
            dic[10] = 0;
            dic[20] = 0;

            foreach (int b in bills)
            {
                if (b == 5)
                {
                    dic[5]++;
                }
                else if (b == 10)
                {
                    dic[10]++;
                    dic[5]--;
                    if (dic[5] < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    dic[20]++;
                    if (!Return15(dic))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool Return15(Dictionary<int, int> dic)
        {
            // we need at leat one 5 
            if (dic[5] <=0)
            {
                return false;
            }

            // check combine like 5 + 10 and 5+5+5
            if (dic[5]>=1 && dic[10]>=1)
            {
                dic[5]--;
                dic[10]--;
                return true;
            }

            if (dic[5]>=3)
            {
                dic[5] -= 3;
                return true;
            }

            return false;
        }
    }
}
