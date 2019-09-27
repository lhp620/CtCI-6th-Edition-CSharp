using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter5
{
    class Is_Valid_BST
    {
        private int lastVal = int.MinValue;
        private bool firstNode = true;

        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (!IsValidBST(root.Left))
            {
                return false;
            }

            if (!firstNode && lastVal >= root.Data)
            {
                return false;
            }

            firstNode = false;
            lastVal = root.Data;

            if (!IsValidBST(root.Right))
            {
                return false;
            }

            return true;
        }

        // 
        public bool IsValidBST1(TreeNode root)
        {
            return helper(root, int.MinValue, int.MaxValue);
        }

        private bool helper(TreeNode root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }

            if (root.Data <= min || root.Data >= max)
            {
                return false;
            }

            return helper(root.Left, min, root.Data) && helper(root.Right, root.Data, max);
        }

        // https://www.geeksforgeeks.org/a-program-to-check-if-a-binary-tree-is-bst-or-not/
        TreeNode pre = null;
        // use inorder travel to valid BST
        public bool IsValidBST2(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            // handle left at first 
            if (!IsValidBST2(root.Left))
            {
                return false;
            }

            // handle the current node value
            if (root != null && root.Data <= pre.Data)
            {
                return false;
            }

            pre = root;

            return IsValidBST2(root.Right);
        }
    }
}
