using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci.Library
{
    public class UndirectedGraphNode
    {
        int label;
        List<List<UndirectedGraphNode>> neighbors;

        public UndirectedGraphNode(int x)
        {
            label = x;
            neighbors = new List<List<UndirectedGraphNode>>();
        }
    }
}
