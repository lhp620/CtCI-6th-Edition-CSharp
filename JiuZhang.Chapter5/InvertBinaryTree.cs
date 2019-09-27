using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter5
{
    class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode right = InvertTree(root.Right);
            TreeNode left = InvertTree(root.Left);

            root.Left = right;
            root.Right = left;

            return root;
        }

        public TreeNode invertTree_Itertaion(TreeNode root)
        {
            if (root == null) return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();
                TreeNode temp = current.Left;
                current.Left = current.Right;
                current.Right = temp;
                if (current.Left != null) queue.Enqueue(current.Left);
                if (current.Right != null) queue.Enqueue(current.Right);
            }
            return root;
        }
    }
}
