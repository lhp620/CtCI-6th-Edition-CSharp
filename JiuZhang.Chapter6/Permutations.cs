using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    class Permutations
    {
        public List<List<int>> Permutations(int[] nums, int n)
        {
            List<List<int>> result = new List<List<int>>();

            if (nums == null || nums.Length == 0)
            {
                return result;
            }

            bool[] used = new bool[nums.Length];
            List<int> current = new List<int>();
            dfs(nums, 0, n, used, current, result);

            return result;
        }

        private void dfs(int[] nums, int index, int n, bool[] used, List<int> current, List<List<int>> result)
        {
            if (current.Count == n)
            {
                result.Add(current);
                return;
            }

            for(int i = index; i < nums.Length; i++)
            {
                if (used[i]) continue;
                used[i] = true;
                current.Add(nums[i]);
                dfs(nums, index + 1, n, used, current, result);
                current.Remove(current.Count - 1);
                used[i] = false;
            }
        }
    }
}
