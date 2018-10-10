using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    public class Dynamic_Programming___Subset_Sum_Problem
    {
        //https://algorithms.tutorialhorizon.com/dynamic-programming-subset-sum-problem/
        public void find(int[] A, int currSum, int index, int sum, int[] solution, List<List<int>> answer)
        {
            if (currSum == sum)
            {
                List<int> temp = new List<int>();
                // add the answer
                for(int i = 0; i < solution.Length; i++)
                {
                    if (solution[i] == 1)
                    {
                        temp.Add(i);
                    }
                }
                answer.Add(temp);
            }
            else if (index == A.Length)
            {
                return;
            }
            else
            {
                solution[index] = 1;
                currSum += A[index];
                find(A, currSum, index + 1, sum, solution, answer);
                currSum -= A[index];
                solution[index] = 0;
                find(A, currSum, index + 1, sum, solution, answer);
            }
            return;
        }
    }
}
