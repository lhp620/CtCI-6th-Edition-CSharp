using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    class Permutation2
    {
        // Given a collection of numbers that might contain duplicates, return all possible unique permutations.
        //https://leetcode.com/problems/permutations-ii/
        public List<List<int>> permuteUnique(int[] nums)
        {
            List<List<int>> res = new List<List<int>>();
            if (nums == null || nums.Length == 0) return res;
            bool[] used = new bool[nums.Length];
            List<int> list = new List<int>();
            Array.Sort(nums);
            dfs(nums, used, list, res);
            return res;
        }

        public void dfs(int[] nums, bool[] used, List<int> list, List<List<int>> res)
        {
            if (list.Count == nums.Length)
            {
                res.Add(new List<int>(list));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i]) continue;
                if (i > 0 && nums[i - 1] == nums[i] && !used[i - 1]) continue;
                used[i] = true;
                list.Add(nums[i]);
                dfs(nums, used, list, res);
                used[i] = false;
                list.Remove(list.Count - 1);
            }
        }
    }
}
