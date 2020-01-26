using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    class _216
    {
        public List<List<int>> combinationSum3(int k, int n)
        {
            List<List<int>> combinations = new List<List<int>>();
            List<int> path = new List<int>();
            backtracking(k, n, 1, path, combinations);
            return combinations;
        }

        private void backtracking(int k, int n, int start,
                                  List<int> tempCombination, List<List<int>> combinations)
        {

            if (k == 0 && n == 0)
            {
                combinations.Add(new List<int>(tempCombination));
                return;
            }
            if (k == 0 || n == 0)
            {
                return;
            }
            for (int i = start; i <= 9; i++)
            {
                tempCombination.Add(i);
                backtracking(k - 1, n - i, i + 1, tempCombination, combinations);
                tempCombination.RemoveAt(tempCombination.Count - 1);
            }
        }
    }
}
