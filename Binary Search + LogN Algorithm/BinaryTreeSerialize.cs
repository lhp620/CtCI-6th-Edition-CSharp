using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter4
{
    class BinaryTreeSerialize
    {
        public string Serialize(TreeNode root)
        {
            if (root == null)
            {
                return "{}";
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            for(int i = 0; i < queue.Count; i++)
            {
                TreeNode node = queue.ToArray()[i];
                if(node == null)
                {
                    continue;
                }

                queue.Enqueue(node.Left);
                queue.Enqueue(node.Right);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append(queue.Dequeue().Data);

            for(int i = 1; i < queue.Count; i++)
            {
                if(queue.Peek() == null)
                {
                    sb.Append(",#");
                }
                else
                {
                    sb.Append(",");
                    sb.Append(queue.Dequeue().Data);
                }
            }

            sb.Append("}");

            return sb.ToString();
        }

        public TreeNode deserialize(String data)
        {
            if (data == "{}")
            {
                return null;
            }
            String[] vals = data.Substring(1, data.Length - 1).Split(',');
            List<TreeNode> queue = new List<TreeNode>();
            TreeNode root = new TreeNode(int.Parse(vals[0]));
            queue.Add(root);
            int index = 0;
            bool isLeftChild = true;
            for (int i = 1; i < vals.Length; i++)
            {
                if (!(vals[i] == "#"))
                {
                    TreeNode node = new TreeNode(int.Parse(vals[i]));
                    if (isLeftChild)
                    {
                        queue[index].Left = node;
                    }
                    else
                    {
                        queue[index].Right = node;
                    }
                    queue.Add(node);
                }
                if (!isLeftChild)
                {
                    index++;
                }
                isLeftChild = !isLeftChild;
            }
            return root;
        }
    }
}
