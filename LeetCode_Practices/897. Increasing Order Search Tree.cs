using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _897
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            // inorder travel at first, and put nodes into a stack
            // pop up the nodes from stack to make a new tree
            Queue<TreeNode> q = new Queue<TreeNode>();
            InOrderTravel(root, ref q);

            TreeNode head = q.Dequeue();
            TreeNode newTree = head;
            while (head != null && q.Count >0)
            {
                head = q.Dequeue();
                newTree.right = head;
            }



            return newTree;
        }

        private void InOrderTravel(TreeNode root, ref Queue<TreeNode> q)
        {
            if (root == null)
            {
                return;
            }

            InOrderTravel(root.left, ref q);
            if (root != null)
            {
                q.Enqueue(root);
            }
            InOrderTravel(root.right, ref q);
        }
    }
}
