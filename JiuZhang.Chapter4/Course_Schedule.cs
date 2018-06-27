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
    }
}