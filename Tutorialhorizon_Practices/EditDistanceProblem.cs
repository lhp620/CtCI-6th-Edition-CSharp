using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorialhorizon_Practices
{
    class EditDistanceProblem
    {
        //https://algorithms.tutorialhorizon.com/dynamic-programming-edit-distance-problem/
        public int EditDistanceRecursion(string s1, string s2, int m, int n)
        {
            // if any of the string is empty then number of operations
            // need would be equal to the length of other string
            // (Either all characters will be removed or inserted)
            if (m == 0)
            {
                return n;
            }
            if (n == 0)
            {
                return m;
            }

            // if last character are matching, ignore the last character
            // and make a recursive call with last character removed
            if (s1[m - 1] == s2[n - 1])
            {
                return EditDistanceRecursion(s1, s2, n - 1, m - 1);
            }

            return 1 + Math.Min(EditDistanceRecursion(s1, s2, m, n - 1),
                Math.Min(EditDistanceRecursion(s1, s2, m - 1, n),
                EditDistanceRecursion(s1, s2, m - 1, n - 1)));
        }


        public int EditDistanceDP(string s1, string s2)
        {
            int[][] solution = new int[s1.Length + 1][];
            for(int i = 0; i < solution.Length +1; i++)
            {
                solution[i] = new int[s2.Length + 1];
            }

            //base case
            // if any of the string is empty then number of operations need would be equal to the length 
            // of other string (Either all characters will be removed or inserted)
            for(int i = 0; i <= s2.Length; i++)
            {
                solution[0][i] = i;
            }

            for(int i = 0; i <= s1.Length; i++)
            {
                solution[i][0] = i;
            }

            // solving it bottom up manner
            int m = s1.Length;
            int n = s2.Length;

            for(int i =1; i < m; i++)
            {
                for(int j = 1; j<n;j++)
                {
                    // if last characters are matching, ignore the last character
                    // then the solution will be same as without the last character
                    if (s1[i-1] == s2[j-1])
                    {
                        solution[i][j] = solution[i - 1][j - 1];
                    }
                    else
                    {
                        solution[i][j] = 1 + Math.Min(solution[i][j - 1], Math.Min(solution[i - 1][j], solution[i - 1][j - 1]));
                    }
                }
            }

            return solution[s1.Length][s2.Length];
        }
    }
}
