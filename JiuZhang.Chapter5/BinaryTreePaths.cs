using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter5
{
    class BinaryTreePaths
    {
        public List<String> binaryTreePaths(TreeNode root)
        {
            List<String> paths = new List<string>();
            if (root == null)
            {
                return paths;
            }

            List<String> leftPaths = binaryTreePaths(root.Left);
            List<String> rightPaths = binaryTreePaths(root.Right);
            foreach (String path in leftPaths)
            {
                paths.Add(root.Data + "->" + path);
            }

            foreach (String path in rightPaths)
            {
                paths.Add(root.Data + "->" + path);
            }

            // root is a leaf
            if (paths.Count == 0)
            {
                paths.Add("" + root.Data);
            }

            return paths;
        }

        public List<String> binaryTreePaths2(TreeNode root)
        {
            List<String> result = new List<string>();
            if (root == null)
            {
                return result;
            }
            helper(root, root.Data.ToString(), result);
            return result;
        }

        private void helper(TreeNode root, String path, List<String> result)
        {
            if (root == null)
            {
                return;
            }

            if (root.Left == null && root.Right == null)
            {
                result.Add(path);
                return;
            }

            if (root.Left != null)
            {
                helper(root.Left, path + "->" + root.Left.Data.ToString(), result);
            }

            if (root.Right != null)
            {
                helper(root.Right, path + "->" + root.Right.Data.ToString(), result);
            }
        }
    }
}
