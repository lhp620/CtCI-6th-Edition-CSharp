using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter5
{
    class BinaryTreeHeight
    {
        TreeNode root;

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                // base case
                return 0;
            }
            else
            {
                // compute the depth of each subtree
                // divide
                int lDepth = MaxDepth(root.Left);
                int rDepth = MaxDepth(root.Right);

                // conquer
                if (lDepth > rDepth)
                {
                    return 1 + lDepth;
                }
                else
                {
                    return 1 + rDepth;
                }
            }
        }
    }
}
