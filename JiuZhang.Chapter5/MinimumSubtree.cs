using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter5
{
    public class MinimumSubtree
    {
        private TreeNode subtree = null;
        private int subtreeSum = Int32.MaxValue;

        public TreeNode findSubtree(TreeNode root)
        {
            helper(root);
            return subtree;
        }

        private int helper(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int sum = helper(root.Left) + helper(root.Right) + root.Data;
            if (sum <= subtreeSum)
            {
                subtreeSum = sum;
                subtree = root;
            }
            return sum;
        }
    }
}
