using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class _894
    {
        Dictionary<int, List<TreeNode>> memo = new Dictionary<int, List<TreeNode>>();

        public IList<TreeNode> AllPossibleFBT(int N)
        {
            if (!memo.ContainsKey(N))
            {
                List<TreeNode> ans = new List<TreeNode>();
                if (N==1)
                {
                    ans.Add(new TreeNode(0));
                }
                else if (N%2 ==1)
                {
                    for (int x = 0; x < N; x++)
                    {
                        int y = N - 1 - x;
                        foreach (TreeNode left in AllPossibleFBT(x))
                        {
                            foreach (TreeNode right in AllPossibleFBT(y))
                            {
                                TreeNode bns = new TreeNode(0);
                                bns.left = left;
                                bns.right = right;
                                ans.Add(bns);
                            }
                        }
                    }
                }
                memo.Add(N, ans);
            }

            return memo[N];
        }
    }
}
