using System;
using System.Collections.Generic;
using System.Text;

namespace JiuZhang.Chapter3
{
    class Two_Sum_Difference_equals_To_Target
    {
        public static int[] TwoSumDifferenceEqualsToTarget(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = nums[i] + target;
                int temp;
                if (map.TryGetValue(sum, out temp))
                {
                    int index = map[sum];
                    int[] pair = new int[2];

                    pair[0] = index + 1;
                    pair[1] = i + 1;

                    return pair;
                }

                int diff = nums[i] - target;
                if (map.TryGetValue(diff, out temp))
                {
                    int index = map[diff];
                    int[] pair = new int[2];

                    pair[0] = index + 1;
                    pair[1] = i + 1;

                    return pair;
                }

                map[nums[i]] = i;
            }

            return null;
        }
    }
}
