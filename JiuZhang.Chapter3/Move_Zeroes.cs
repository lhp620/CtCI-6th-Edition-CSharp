using System;
using System.Collections.Generic;
using System.Text;

namespace JiuZhang.Chapter3
{
    public class Move_Zeroes
    {
        public static int[] MoveZeroes(int[] array)
        {
            int left = 0, right = 0;

            // use right to go through the array
            while(right < array.Length)
            {
                if (array[right] != 0)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                }
                right++;
            }

            return array;
        }
    }
}
