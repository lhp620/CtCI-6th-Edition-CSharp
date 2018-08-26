using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class Possible_Bipartition
    {
        // https://leetcode.com/problems/possible-bipartition/discuss/158957/Java-DFS-solution
        public bool PossibleBipartition(int N, int[][] dislikes)
        {
            int[][] graph = new int[N][];

            for(int i = 0; i < graph.Length; i++)
            {
                graph[i] = new int[N];
            }

            foreach (var d in dislikes)
            {
                graph[d[0] - 1][d[1] - 1] = 1;
                graph[d[1] - 1][d[0] - 1] = 1;
            }

            int[] group = new int[N];

            for(int i = 0; i < N; i++)
            {
                if (group[i] == 0 && !dfs(graph, group, i, 1))
                {
                    return false;
                }
            }

            return true;
        }

        private bool dfs(int[][] graph, int[] group, int index, int g)
        {
            group[index] = g;
            for (int i = 0; i < graph.Length; i++)
            {
                if (graph[index][i] == 1)
                {
                    if (group[i] == g)
                    {
                        return false;
                    }
                    if (group[i] ==0 && !dfs(graph, group,i,-g))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
