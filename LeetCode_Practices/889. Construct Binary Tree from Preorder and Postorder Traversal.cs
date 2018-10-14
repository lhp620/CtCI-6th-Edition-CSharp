using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _889
    {
        public TreeNode ConstructFromPrePost(int[] pre, int[] post)
        {
            int N = pre.Length;
            if (N == 0) return null;
            TreeNode root = new TreeNode(pre[0]);
            if (N == 1) return root;

            int L = 0;
            for (int i = 0; i < N; ++i)
                if (post[i] == pre[1])
                    L = i + 1;

            root.left = ConstructFromPrePost(CopyOfRange(pre, 1, L + 1),
                                             CopyOfRange(post, 0, L));
            root.right = ConstructFromPrePost(CopyOfRange(pre, L + 1, N),
                                              CopyOfRange(post, L, N - 1));
            return root;
        }

        private int[] CopyOfRange(int[] p, int left, int right)
        {
            int[] ans = new int[right - left];
            int j = 0;
            for (int i = left; i < right; i++ )
            {
                ans[j] = p[i];
            }

            return ans;
        }
    }
}
