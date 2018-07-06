using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter9
{
    class Intersection_of_Two_Arrays
    {
        public int[] intersection(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            int i = 0, j = 0;
            int[] temp = new int[nums1.Length];
            int index = 0;

            while (i<nums1.Length && j <nums1.Length)
            {
                if (nums1[i] == nums1[j])
                {
                    if (index == 0 || temp[index-1] != nums1[i])
                    {
                        temp[index++] = nums1[i];
                    }

                    i++;
                    j++;
                }
                else if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            int[] result = new int[index];
            for (int k = 0; k < index; k++)
            {
                result[k] = temp[k];
            }

            return result;
        }
    }
}