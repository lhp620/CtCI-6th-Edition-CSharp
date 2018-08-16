using System;
using System.Collections.Generic;
using System.Text;

namespace Ch_04._Tree
{
    public enum State { Unvisited, Visited, Visiting };

    class Q4_01_Route_Between_Nodes
    {
        bool Search (Graph g, Node start, Node end)
        {
            if (start == end)
            {
                return true;
            }

            // Operates as Queue
            Queue<Node> q = new Queue<Node>();

            foreach (Node n in g.GetNodes())
            {
                n.state = State.Unvisited;
            }

            start.state = State.Visiting;

            q.Enqueue(start);

            Node u;

            while(q.Count != 0)
            {
                u = q.Dequeue();
                if (u != null)
                {
                    foreach (Node v in u.GetAdjacents())
                    {
                        if (v.state == State.Unvisited)
                        {
                            if (v == end)
                            {
                                return true;
                            }
                            else
                            {
                                v.state = State.Visiting;
                                q.Enqueue(v);
                            }
                        }
                    }
                }
                u.state = State.Visited;
            }

            return false;
        }
    }

    internal class Node
    {
        public State state;

        internal IEnumerable<Node> GetAdjacents()
        {
            throw new NotImplementedException();
        }
    }
}
