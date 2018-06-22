using System;

namespace JiuZhang.Chapter3
{
    public class Windows_Sum
    {
        public static int[] WindowsSum(int[] array, int k)
        {
            if (array == null || array.Length == 0)
            {
                return new int[0];
            }

            int[] sums = new int[array.Length - k + 1];
            for (int i = 0; i < k; i++)
            {
                sums[0] += array[i];
            }

            for (int i=1; i < sums.Length; i++)
            {
                sums[i] = sums[i - 1] - array[i - 1] + array[i + k - 1];
            }

            return sums;
        }
    }
}
