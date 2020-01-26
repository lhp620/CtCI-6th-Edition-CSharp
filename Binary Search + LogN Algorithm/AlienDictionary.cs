using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter4
{
    // https://leetcode.com/problems/alien-dictionary/
    //https://www.cnblogs.com/grandyang/p/5250200.html
    class AlienDictionary
    {
        public String alienOrder(String[] words)
        {
            Dictionary<char, HashSet<char>> graph = constructGraph(words);
            return topologicalSorting(graph);
        }


        private Dictionary<char, HashSet<char>> constructGraph(String[] words)
        {
            Dictionary<char, HashSet<char>> graph = new Dictionary<char, HashSet<char>>();

            // create nodes
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].ToCharArray().Count(); j++)
                {
                    char c = words[i][j];
                    if (!graph.ContainsKey(c))
                    {
                        graph.Add(c, new HashSet<char>());
                    }
                }
            }

            // create edges
            for (int i = 0; i < words.Length - 1; i++)
            {
                int index = 0;
                while (index < words[i].ToCharArray().Count() && index < words[i + 1].ToCharArray().Count())
                {
                    if (words[i][index] != words[i + 1][index])
                    {
                        graph[words[i][index]].Add(words[i + 1][index]);
                        break;
                    }
                    index++;
                }
            }

            return graph;
        }

        private Dictionary<char, int> getIndegree(Dictionary<char, HashSet<char>> graph)
        {
            Dictionary<char, int> indegree = new Dictionary<char, int>();
            foreach (char u in graph.Keys)
            {
                indegree.Add(u, 0);
            }

            foreach (char u in graph.Keys)
            {
                foreach (char v in graph[u])
                {
                    indegree.Add(v, indegree[v] + 1);
                }
            }

            return indegree;
        }

        private String topologicalSorting(Dictionary<char, HashSet<char>> graph)
        {
            Dictionary<char, int> indegree = getIndegree(graph);
            // as we should return the topo order with lexicographical order
            // we should use PriorityQueue instead of a FIFO Queue
            Queue<char> queue = new Queue<char>();

            foreach (char u in indegree.Keys)
            {
                if (indegree[u] == 0)
                {
                    queue.Enqueue(u);
                }
            }

            StringBuilder sb = new StringBuilder();
            while (queue.Count > 0)
            {
                char head = queue.Dequeue();
                sb.Append(head);
                foreach (char neighbor in graph[head])
                {
                    indegree.Add(neighbor, indegree[neighbor] - 1);
                    if (indegree[neighbor] == 0)
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }

            if (sb.Length != indegree.Keys.Count)
            {
                return "";
            }
            return sb.ToString();
        }
    }
}
