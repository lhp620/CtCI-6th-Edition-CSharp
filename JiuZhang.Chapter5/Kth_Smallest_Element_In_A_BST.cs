using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter5
{
    class Kth_Smallest_Element_In_A_BST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            Dictionary<TreeNode, int> numOfChildren = new Dictionary<TreeNode, int>();
            countNodes(root, numOfChildren);

            return QuickSelectOnTree(root, k, numOfChildren);

        }

        private int QuickSelectOnTree(TreeNode root, int k, Dictionary<TreeNode, int> numOfChildren)
        {
            if (root == null)
            {
                return -1;
            }

            int left = root.Left == null ? 0 : numOfChildren[root.Left];
            if (left >= k)
            {
                return QuickSelectOnTree(root.Left, k, numOfChildren);
            }
            else if (left + 1 == k)
            {
                return root.Data;
            }
            else
            {
                return QuickSelectOnTree(root.Right, k, numOfChildren);
            }

        }

        private int countNodes(TreeNode root, Dictionary<TreeNode, int> numOfChildren)
        {
            if (root == null)
            {
                return 0;
            }

            int left = countNodes(root.Left, numOfChildren);
            int right = countNodes(root.Right, numOfChildren);

            numOfChildren.Add(root, left + right + 1);

            return left + right + 1;
        }

        public int KthSmallest_(TreeNode root, int k)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();

            while (root != null)
            {
                stack.Push(root);
                root = root.Left;
            }

            // use inorder to travel the tree and stop at the k step
            for (int i = 0; i < k -1; i++)
            {
                TreeNode node = stack.Peek();

                if (node.Right == null)
                {
                    node = stack.Pop();
                    while (stack.Count > 0 && stack.Peek().Right == node)
                    {
                        node = stack.Pop();
                    }
                }
                else
                {
                    node = node.Right;
                    while(node != null)
                    {
                        stack.Push(node);
                        node = node.Left;
                    }
                }

            }
            return stack.Peek().Data;

        }
    }
}
