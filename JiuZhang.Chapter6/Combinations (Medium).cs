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
            {  // 剪枝
                combineList.Add(i);
                backtracking(combineList, combinations, i + 1, k - 1, n);
                combineList.RemoveAt(combineList.Count - 1);
            }
        }
    }
}
