using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _865
    {
        Dictionary<TreeNode, int> depth;
        int max_depth;
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            depth = new Dictionary<TreeNode, int>();
            TreeNode temp = new TreeNode(0);
            depth[temp] = -1;
            dfs(root, temp);
            max_depth = -1;
            foreach (int d in depth.Values)
            {
                max_depth = Math.Max(max_depth, d);
            }

            return answer(root);
        }

        private void dfs(TreeNode node, TreeNode parent)
        {
            if (node != null)
            {
                depth[node] = depth[parent] + 1;
                dfs(node.left, node);
                dfs(node.right, node);
            }
        }
        public TreeNode answer(TreeNode node)
        {
            if (node == null || depth[node] == max_depth)
            {
                return node;
            }

            TreeNode L = answer(node.left),
                     R = answer(node.right);

            if (L != null && R!= null)
            {
                return node;
            }

            if (L != null)
            {
                return L;
            }

            if (R != null)
            {
                return R;
            }

            return null;
        }

    }
}
