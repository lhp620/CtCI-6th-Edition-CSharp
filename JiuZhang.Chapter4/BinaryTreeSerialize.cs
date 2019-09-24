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
    }
}
