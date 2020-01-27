using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    class SubSets
    {
        /// <summary>
        /// Given a set of distinct integers, nums, return all possible subsets (the power set).
        //        Note: The solution set must not contain duplicate subsets.

        //        Example:

        //Input: nums = [1, 2, 3]
        //        Output:
        //[
        //          [3],
        //          [1],
        //          [2],
        //          [1,2,3],
        //          [1,3],
        //          [2,3],
        //          [1,2],
        //          []
        //]
        /// </summary>
        List<List<int>> result = new List<List<int>>();
        public List<List<int>> SubSet(int[] nums, int Target)
        {
            if (nums == null || nums.Length == 0)
            {
                return result;
            }
            List<int> cur = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dfs(nums, 0, i, cur);
            }

            return result;
        }

        private void dfs(int[] nums, int index, int totalNum, List<int> cur)
        {
            if (cur.Count == totalNum)
            {
                result.Add(new List<int>(cur));
                return;
            }

            for (int i = index; i < nums.Length; i++)
            {
                cur.Add(nums[i]);
                dfs(nums, index + 1, totalNum, cur);
                cur.RemoveAt(cur.Count - 1);
            }
        }
    }
}
