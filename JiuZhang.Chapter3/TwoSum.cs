using System;
using System.Collections.Generic;
using System.Text;

namespace JiuZhang.Chapter5_twopoints
{
    class TwoSum
    {
        public int[] Two_Sum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map.Add(nums[i], i);
            }
            throw new Exception("No two sum solution");
        }

        public static List<List<int>> TwoSum_TwoPoints(int[] array, int target)
        {
            List<List<int>> results = new List<List<int>>();

            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                if (array[left] + array[right] == target)
                {
                    List<int> triple = new List<int>();
                    triple.Add(-target);
                    triple.Add(array[left]);
                    triple.Add(array[right]);

                    results.Add(triple);
                    left++;
                    right--;

                    while (left < right && array[left] == array[left - 1])
                    {
                        left++;
                    }

                    while (left < right && array[right] == array[right + 1])
                    {
                        right--;
                    }
                }
                else if (array[left] + array[right] < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return results;
        }
    }
}
