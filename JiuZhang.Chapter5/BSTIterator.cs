using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter5
{
    class BSTIterator
    {
        private Stack<TreeNode> stack = new Stack<TreeNode>();

        // @param root: The root of binary tree.
        public BSTIterator(TreeNode root)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.Left;
            }
        }

        //@return: True if there has next node, or false
        public bool hasNext()
        {
            return !(stack.Count == 0);
        }

        //@return: return next node
        public TreeNode next()
        {
            TreeNode curt = stack.Peek();
            TreeNode node = curt;

            // move to the next node
            if (node.Right == null)
            {
                node = stack.Pop();
                while (!(stack.Count == 0) && stack.Peek().Right == node)
                {
                    node = stack.Pop();
                }
            }
            else
            {
                node = node.Right;
                while (node != null)
                {
                    stack.Push(node);
                    node = node.Left;
                }
            }

            return curt;
        }
    }
}
