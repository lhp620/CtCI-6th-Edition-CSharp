using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    class Combinations__Medium_
    {
        //https://leetcode.com/problems/combinations/description/
        public List<List<int>> combine(int n, int k)
        {
            List<List<int>> combinations = new List<List<int>>();
            List<int> combineList = new List<int>();
            backtracking(combineList, combinations, 1, k, n);
            return combinations;
        }

        private void backtracking(List<int> combineList, List<List<int>> combinations, int start, int k, int n)
        {
            if (k == 0)
            {
                combinations.Add(new List<int>(combineList));
                return;
            }
            for (int i = start; i <= n - k + 1; i++)
            {  // add the first number into tempResult
                combineList.Add(i);
                // recursively add the next number into tempResult, untill k == 0
                backtracking(combineList, combinations, i + 1, k - 1, n);
                // remove the first number, prepare to add the second number into tempResult, untill n - k + 1 (last k not need add to tempResult, as they will call by the backtracking way)
                combineList.RemoveAt(combineList.Count - 1);
            }
        }
    }
}
