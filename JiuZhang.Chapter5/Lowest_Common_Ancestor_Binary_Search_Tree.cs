using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter5
{
    class Lowest_Common_Ancestor_Binary_Search_Tree
    {
        public TreeNode LCABinarySeachTree(TreeNode node, int n1, int n2)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Data > n1 && node.Data > n2)
            {
                return LCABinarySeachTree(node.Left, n1, n2);
            }
            else if (node.Data < n1 && node.Data < n2)
            {
                return LCABinarySeachTree(node.Right, n1, n2);
            }
            else
            {
                return node;
            }
        }

        public TreeNode LCABinarySearchTree2(TreeNode root, int n1, int n2)
        {
            while(root != null)
            {
                if (root.Data > n1 && root.Data > n2)
                {
                    root = root.Left;
                }
                else if (root.Data < n1 && root.Data < n2)
                {
                    root = root.Right;
                }
                else
                {
                    break;
                }
            }

            return root;
        }
    }
}
