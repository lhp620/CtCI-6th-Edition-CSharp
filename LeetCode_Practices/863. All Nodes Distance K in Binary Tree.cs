using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _863
    {
        List<int> ans;
        TreeNode target;
        int K;

        public IList<int> DistanceK(TreeNode root, TreeNode target, int K)
        {
            ans = new List<int>();
            this.target = target;
            this.K = K;
            dfs(root);
            return ans;
        }

        public int dfs(TreeNode node)
        {
            if (node == null)
            {
                return -1;
            }
            else if (node == target)
            {
                subtree_add(node, 0);
                return 1;
            }
            else
            {
                int L = dfs(node.left), R = dfs(node.right);
                if (L != -1)
                {
                    if (L==K)
                    {
                        ans.Add(node.val);
                    }
                    subtree_add(node.right, L + 1);
                    return L + 1;
                }
                else if (R != -1)
                {
                    if (R==K)
                    {
                        ans.Add(node.val);
                    }
                    subtree_add(node.left, R + 1);
                    return R + 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public void subtree_add(TreeNode node, int dist)
        {
            if (node == null)
            {
                return;
            }

            if (dist == K)
            {
                ans.Add(node.val);
            }
            else
            {
                subtree_add(node.left, dist + 1);
                subtree_add(node.right, dist + 1);
            }
        }
    }
}
