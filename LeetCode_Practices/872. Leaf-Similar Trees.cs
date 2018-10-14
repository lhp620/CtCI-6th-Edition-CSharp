using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class _872
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> leaves1 = new List<int>();
            List<int> leaves2 = new List<int>();
            GetLeaves(root1, leaves1);
            GetLeaves(root2, leaves2);
            if (Equals(leaves1, leaves2))
            {
                return true;
            }
            return false;
        }

        // dfs find leaves
        private void GetLeaves(TreeNode root, List<int> leaves)
        {
            if (root != null)
            {
                if (root.left == null && root.right == null)
                {
                    leaves.Add(root.val);
                }
                GetLeaves(root.left, leaves);
                GetLeaves(root.right, leaves);
            }
        }

        private bool Equals(List<int> l1, List<int> l2)
        {
            if (l1.Count != l2.Count)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < l1.Count; i++)
                {
                    if (l1[i] != l2[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
