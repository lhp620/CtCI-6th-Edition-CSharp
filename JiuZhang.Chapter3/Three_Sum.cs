using System;
using System.Collections.Generic;
using System.Text;

namespace JiuZhang.Chapter3
{
    public class Three_Sum
    {
        // find 3 elements in array, the summary is 0
        public static List<List<int>> ThreeSum(int[] array)
        {
            List<List<int>> results = new List<List<int>>();

            if (array == null || array.Length == 0)
            {
                return results;
            }

            Array.Sort(array);

            for (int i = 0; i < array.Length -2; i++)
            {
                if (i > 0 && array[i] == array[i -1])
                {
                    continue;
                }

                int left = i + 1, right = array.Length - 1;
                int target = -array[i];

                TwoSum(array, left, right, target, results);
            }

            return results;
        }

        private static void TwoSum(int[] array, int left, int right, int target, List<List<int>> results)
        {
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
        }
    }
}
