using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter5
{
    class Closest_Binary_Search_Tree_Value_II
    {
        public List<int> ClosestKValue(TreeNode root, double target, int k)
        {
            List<int> values = new List<int>();

            InOrderTravel(root, values);

            int i = 0, n = values.Count - 1;
            for (; i < n; i++)
            {
                if (values[i] >= target)
                {
                    break;
                }
            }

            if (i >= n)
            {
                return values.GetRange(n - k, k);
            }
            int left = i - 1, right = i;
            List<int> result = new List<int>();
            for (i = 0; i < k; i++)
            {
                if (left >= 0 && (right >= n || target - values[left] < values[right] - target))
                {
                    result.Add(values[left]);
                    left--;
                }
                else
                {
                    result.Add(values[right]);
                    right++;
                }
            }

            return result;
        }

        private void InOrderTravel(TreeNode root, List<int> values)
        {
            if (root == null)
            {
                return;
            }

            InOrderTravel(root.Left, values);
            values.Add(root.Data);
            InOrderTravel(root.Right, values);
        }
    }
}
