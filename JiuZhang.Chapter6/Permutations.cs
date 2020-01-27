using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    /// <summary>
    /// Given a collection of distinct integers, return all possible permutations.
    //Example:
    //Input: [1,2,3]
    //Output:
    //[
    //  [1,2,3],
    //  [1,3,2],
    //  [2,1,3],
    //  [2,3,1],
    //  [3,1,2],
    //  [3,2,1]
    //]
    /// </summary>
    public class Permutations
    {
        // https://leetcode.com/problems/permutations/discuss/18239/A-general-approach-to-backtracking-questions-in-Java-(Subsets-Permutations-Combination-Sum-Palindrome-Partioning)
        // https://leetcode.com/problems/permutations/
        public static IList<IList<int>> Permutations_(int[] nums, int n)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums == null || nums.Length == 0)
            {
                return result;
            }

            bool[] used = new bool[nums.Length];
            List<int> current = new List<int>();
            dfs(nums, 0, n, used, current, result);

            return result;
        }

        private static void dfs(int[] nums, int index, int n, bool[] used, List<int> current, IList<IList<int>> result)
        {
            if (current.Count == n)
            {
                // wrong to use result.Add(current) as current will be clear to empty at the end. need new a List<int>(current) to save the result without ref
                result.Add(new List<int>(current));
                return;
            }

            for (int i = index; i < nums.Length; i++)
            {
                if (used[i]) { continue; }
                used[i] = true;
                current.Add(nums[i]);
                // the index should always from 0, and this index could be removed.
                dfs(nums, 0, n, used, current, result);
                current.RemoveAt(current.Count - 1);
                used[i] = false;
            }
        }
    }
}
