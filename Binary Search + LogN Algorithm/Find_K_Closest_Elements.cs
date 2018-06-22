using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter2
{
    public class Find_K_Closest_Elements
    {
        public static int[] FindKClosestElements(int[] array, int target, int k)
        {
            int left = FindLowerClosest(array, target);
            int right = left + 1;

            int[] results = new int[k];
            bool only_move_left = false;
            bool only_move_right = false;

            for (int i = 0; i < k; i++)
            {
                if (only_move_left)
                {
                    results[i] = array[left];
                    if (left - 1 > 0)
                    {
                        left--;
                    }
                    else
                    {
                        only_move_right = true;
                    }
                }
                else if (only_move_right)
                {
                    results[i] = array[right];
                    if (right + 1 < array.Length)
                    {
                        right++;
                    }
                    else
                    {
                        only_move_left = true;
                    }
                }
                else if (IsLeftCloser(array, target, left, right))
                {
                    results[i] = array[left];
                    if (left - 1 > 0)
                    {
                        left--;
                    }
                    else
                    {
                        only_move_right = true;
                    }
                }
                else
                {
                    results[i] = array[right];
                    if (right + 1 < array.Length)
                    {
                        right++;
                    }
                    else
                    {
                        only_move_left = true;
                    }
                }
            }

            return results;
        }

        private static bool IsLeftCloser(int[] array, int target, int left, int right)
        {
            if (left < 0)
            {
                return false;
            }

            if (right > array.Length)
            {
                return true;
            }

            if (target - array[left] != array[right] - target)
            {
                return target - array[left] < array[right] - target;
            }

            return true;
        }

        private static int FindLowerClosest(int[] array, int target)
        {
            // find the last element smaller than target
            int start = 0;
            int end = array.Length - 1;

            while (start + 1 < end)
            {
                int middle = start + (end - start) / 2;

                if (array[middle] < target)
                {
                    start = middle;
                }
                else
                {
                    end = middle;
                }
            }

            if (array[end] < target)
            {
                return end;
            }
            else if (array[start] < target)
            {
                return start;
            }

            return -1;
        }
    }
}
