using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter5
{
    public class Lowest_Common_Ancestor
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode node1, TreeNode node2)
        {
            if (root == null || root == node1 || root == node2)
            {
                return root;
            }

            // Divide
            TreeNode left = LowestCommonAncestor(root.Left, node1, node2);
            TreeNode right = LowestCommonAncestor(root.Right, node1, node2);

            // Conquer
            if (left != null && right != null)
            {
                return root;
            }
            else if (left != null)
            {
                return left;
            }
            else if (right != null)
            {
                return right;
            }

            return null;
        }
    }
}
