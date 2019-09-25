using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter4
{
    class Course_Schedule
    {
        // https://en.wikipedia.org/wiki/Topological_sorting
        public bool CanFinish(int numCourses, int[][] prerequisities)
        {
            List<List<int>> edges = new List<List<int>>();
            int[] degree = new int[numCourses];

            for (int i = 0; i<numCourses; i++)
            {
                edges[i] = new List<int>();
            }

            for (int i = 0; i < prerequisities.Length; i++)
            {
                degree[prerequisities[i][0]]++;
                edges[prerequisities[i][1]].Add(prerequisities[i][0]);
            }

            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < degree.Length; i++)
            {
                if (degree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            int count = 0;
            while(queue.Count > 0)
            {
                int course = queue.Dequeue();
                count++;
                int n = edges[course].Count;
                for(int i = 0; i < n; i++)
                {
                    int pointer = edges[course][i];
                    degree[pointer]--;
                    if (degree[pointer] == 0)
                    {
                        queue.Enqueue(pointer);
                    }
                }
            }

            return count == numCourses;
        }

        public bool CanFinish_DFS(int numCourses, int[][] prerequisities)
        {
            //make graph
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            for(int i = 0; i < prerequisities.Length; i++)
            {
                graph[i].Add(prerequisities[i][0]);
            }
            for (int i = 0; i < prerequisities.Length; i++)
            {
                graph[prerequisities[i][1]].Add(prerequisities[i][0]);
            }

            bool[] todo = new bool[numCourses]; 
            bool[] done = new bool[numCourses];
            for(int i = 0; i < numCourses; i++)
            {
                todo[i] = false;
                done[i] = false;
            }
            //foreach course run dfs to check if there is cycle
            for(int i = 0; i < numCourses; i++)
            {
                if (!done[i] && dfs_cycle(graph, i, todo, done))
                {
                    return false;
                }
            }

            return true;
        }

        private bool dfs_cycle(Dictionary<int, List<int>>graph, int node, bool[] todo, bool[] done)
        {
            if (done[node])
            {
                return false;
            }

            todo[node] = done[node] = true;
            foreach (var neighbor in graph[node])
            {
                if (todo[neighbor] || dfs_cycle(graph, neighbor, todo, done))
                {
                    return true;
                }
            }

            todo[node] = false;
            return false;
        }
    }
}