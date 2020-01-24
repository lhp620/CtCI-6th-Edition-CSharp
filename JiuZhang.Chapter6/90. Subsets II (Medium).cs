using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    class _90
    {
        //https://leetcode.com/problems/subsets-ii/description/ 
        public List<List<int>> subsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            List<List<int>> subsets = new List<List<int>>();
            List<int> tempSubset = new List<int>();
            bool[] hasVisited = new bool[nums.Length];
            for (int size = 0; size <= nums.Length; size++)
            {
                backtracking(0, tempSubset, subsets, hasVisited, size, nums); // 不同的子集大小
            }
            return subsets;
        }

        private void backtracking(int start, List<int> tempSubset, List<List<int>> subsets, bool[] hasVisited,
                                  int size, int[] nums)
        {

            if (tempSubset.Count == size)
            {
                subsets.Add(new List<int>(tempSubset));
                return;
            }
            for (int i = start; i < nums.Length; i++)
            {
                if (i != 0 && nums[i] == nums[i - 1] && !hasVisited[i - 1])
                {
                    continue;
                }
                tempSubset.Add(nums[i]);
                hasVisited[i] = true;
                backtracking(i + 1, tempSubset, subsets, hasVisited, size, nums);
                hasVisited[i] = false;
                tempSubset.RemoveAt(tempSubset.Count - 1);
            }
        }
    }
}
