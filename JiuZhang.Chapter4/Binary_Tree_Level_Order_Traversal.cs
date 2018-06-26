using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ctci.Library;

namespace JiuZhang.Chapter4
{
    public class Binary_Tree_Level_Order_Traversal
    {
        public static List<List<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();

            if (root == null)
            {
                return result;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                List<int> level = new List<int>();
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode head = queue.Dequeue();
                    level.Add(head.Data);
                    if (head.Left != null)
                    {
                        queue.Enqueue(head.Left);
                    }
                    if (head.Right != null)
                    {
                        queue.Enqueue(head.Right);
                    }

                    result.Add(level);
                }
            }

            return result;
        }
    }
}
