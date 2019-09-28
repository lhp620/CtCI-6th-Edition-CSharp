using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter5
{
    class Subtree_with_Maximum_Average
    {
        int result = int.MinValue;
        public TreeNode FindSubTreeWithMaximumAverage(TreeNode root)
        {
            ResultType rootResult = FindSWMAHelper(root);
            return rootResult.node;
        }

        private ResultType FindSWMAHelper(TreeNode root)
        {
            if (root == null)
            {
                return new ResultType(null, 0, 0);
            }

            // Divide 
            ResultType CurrentResult = new ResultType(root,
                root.Data + FindSWMAHelper(root.Left).sum + FindSWMAHelper(root.Right).sum,
                1 + FindSWMAHelper(root.Left).size + FindSWMAHelper(root.Right).size);

            // Conquer
            if (CurrentResult.sum / CurrentResult.size > result)
            {
                result = CurrentResult.sum / CurrentResult.size;
            }

            return CurrentResult;
        }
    }

    class ResultType
    {
        public TreeNode node;
        public int sum;
        public int size;
        public ResultType(TreeNode node, int sum, int size)
        {
            this.node = node;
            this.sum = sum;
            this.size = size;
        }
    }
}
