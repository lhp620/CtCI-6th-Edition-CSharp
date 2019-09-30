using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter6
{
    /// <summary>
    /// Given a set of candidate numbers (candidates) (without duplicates) and a target number (target), find all unique combinations in candidates where the candidate numbers sums to target.
    /// The same repeated number may be chosen from candidates unlimited number of times.
    /// </summary>
    public class Combination_Sum
    {
        public List<List<int>> CombinationSum(int[] candidates, int target)
        {
            List<List<int>> result = new List<List<int>>();

            if (candidates == null)
            {
                return result;
            }

            List<int> combination = new List<int>();
            Array.Sort(candidates);
            helper(candidates, 0, target, combination, result);

            return result;
        }

        private void helper(int[] candidates, int index, int target, List<int> combination, List<List<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(combination));
                return;
            }

            for (int i = index; i < candidates.Length; i++)
            {
                if (candidates[i] < target)
                {
                    break;
                }

                if (i != 0 && candidates[i] == candidates[i - 1])
                {
                    continue;
                }

                combination.Add(candidates[i]);
                helper(candidates, i, target - candidates[i], combination, result);
                // this combination is just to keep the current number we are using
                // after using it, clean it and wait to be added a new one
                combination.RemoveAt(combination.Count - 1);
            }
        }

        // https://leetcode.com/problems/combination-sum/discuss/16502/A-general-approach-to-backtracking-questions-in-Java-(Subsets-Permutations-Combination-Sum-Palindrome-Partitioning)
        // Combination Sum : https://leetcode.com/problems/combination-sum/
        public static List<List<int>> combinationSum(int[] nums, int target)
        {
            List<List<int>> list = new List<List<int>>();
            Array.Sort(nums);

            backtrack(list, new List<int>(), nums, target, 0);
            return list;
        }

        private static void backtrack(List<List<int>> list, List<int> tempList, int[] nums, int remain, int start)
        {
            if (remain < 0)
            {
                return;
            }
            else if (remain ==0)
            {
                list.Add(new List<int>(tempList));
            }
            else
            {
                for (int i = start; i < nums.Length; i++)
                {
                    tempList.Add(nums[i]);
                    backtrack(list, tempList, nums, remain - nums[i], i);
                    tempList.RemoveAt(tempList.Count - 1);
                }
            }
        }
    }
}