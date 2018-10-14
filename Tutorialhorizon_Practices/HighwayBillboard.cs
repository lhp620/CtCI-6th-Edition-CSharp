using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    class HighwayBillboard
    {
        public int maxRevence(int[] billboard, int[] revenue, int distance, int milesRes)
        {
            int[] solution = new int[distance];
            solution[0] = revenue[0];

            for(int i = 0; i < distance; i++)
            {
                int maxRevence = 0;
                for (int j = 0; j < i; j++)
                {
                    if (billboard[i] - billboard[j] > milesRes)
                    {
                        if (maxRevence < solution[j])
                        {
                            maxRevence = solution[j];
                        }
                    }
                }

                solution[i] = maxRevence + revenue[i];
            }

            return solution[distance];
        }
    }
}
