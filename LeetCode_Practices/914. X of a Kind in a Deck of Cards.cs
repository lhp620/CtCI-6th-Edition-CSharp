using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _914
    {
        public bool HasGroupsSizeX(int[] deck)
        {
            // create a dictionary and check the count of each number
            Dictionary<int, int> dic = new Dictionary<int, int>();

			foreach (int d in deck)
            {
				if (dic.Keys.Contains(d))
                {
                    dic[d]++;
                }
				else
                {
                    dic[d] = 1;
                }
            }

            // check if each value to match the request
			for(int i = 2; i <= deck.Length; i++)
            {
                int temp = 0;
                foreach (int v in dic.Values)
                {
					if (v % i != 0)
                    {
                        break;
                    }
					else
                    {
                        temp++;
                    }

					if (temp == dic.Keys.Count)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
