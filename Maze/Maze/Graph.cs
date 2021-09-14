using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Graph
    {
        private Dictionary<int, HashSet<int>> edgeTo;
        public Graph()
        {
            edgeTo = new Dictionary<int, HashSet<int>>();
        }
        public int Size()
        {
            return edgeTo.Count;
        }
        public void AddEdge(int v1, int v2)
        {
            Add(v1, v2);
            Add(v2, v1);
        }
        public void Add(int from, int to)
        {
            if (!edgeTo.ContainsKey(from))
            {
                HashSet<int> s = new()
                {
                    to
                };
                edgeTo.Add(from, s);
            }
            else
            {
                edgeTo[from].Add(to);
            }
        }
        public HashSet<int> Adj(int v)
        {
            return edgeTo[v];
        }
    }
}