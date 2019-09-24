using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    class SubSets
    {
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
                result.Add(cur);
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
