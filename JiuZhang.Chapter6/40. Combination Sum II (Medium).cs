using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    class _40
    {
        // https://leetcode.com/problems/combination-sum-ii/description/
        public List<List<int>> combinationSum2(int[] candidates, int target)
        {
            List<List<int>> combinations = new List<List<int>>();
            Array.Sort(candidates);
            backtracking(new List<int>(), combinations, new bool[candidates.Length], 0, target, candidates);
            return combinations;
        }

        private void backtracking(List<int> tempCombination, List<List<int>> combinations,
                                  bool[] hasVisited, int start, int target, int[] candidates)
        {

            if (target == 0)
            {
                combinations.Add(new List<int>(tempCombination));
                return;
            }
            for (int i = start; i < candidates.Length; i++)
            {
                if (i != 0 && candidates[i] == candidates[i - 1] && !hasVisited[i - 1])
                {
                    continue;
                }
                if (candidates[i] <= target)
                {
                    tempCombination.Add(candidates[i]);
                    hasVisited[i] = true;
                    backtracking(tempCombination, combinations, hasVisited, i + 1, target - candidates[i], candidates);
                    hasVisited[i] = false;
                    tempCombination.RemoveAt(tempCombination.Count - 1);
                }
            }
        }
    }
}
