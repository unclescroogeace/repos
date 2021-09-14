using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    class PathFinder
    {

        private static int startVertex;
        private static int endVertex;
        private static bool isStartVertexEdgeAvailable = false;
        public static Graph CreateGraph(Tile[,] tiles)
        {
            Graph graph = new();
            for (int x = 0; x < tiles.GetLength(0); x++)
            {
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    char character = Board.GetTileBackColor(tiles[x, y]);
                    if (character == 'G')
                    {
                        startVertex = tiles[x, y].Id;
                    }
                    else if (character == 'R')
                    {
                        endVertex = tiles[x, y].Id;
                    }
                    if (!IsFreeCell(tiles[x, y]))
                    {
                        continue;
                    }
                    CreateNeighbor(x, y, tiles, graph);
                }
            }
            return graph;
        }
        private static void CreateNeighbor(int r, int c, Tile[,] tiles, Graph graph)
        {
            for (int row = -1; row <= 1; row++)
            {
                for (int col = -1; col <= 1; col++)
                {
                    if (row + r >= Board.BoardSize.Item1 || col + c >= Board.BoardSize.Item2)
                    {
                        continue;
                    }
                    if (row == 0 && col == 0)
                    {
                        continue;
                    }
                    if ((0 > c + col) || (c + col >= tiles.GetLength(0)) || (0 > r + row) || (r + row >= tiles.GetLength(1)))
                    {
                        continue;
                    }
                    if (!IsFreeCell(tiles[r + row, c + col]))
                    {
                        continue;
                    }
                    if (tiles[r, c].Id == startVertex)
                    {
                        isStartVertexEdgeAvailable = true;
                    }
                    graph.Add(tiles[r, c].Id, tiles[row + r, col + c].Id);
                }
            }

        }
        private static bool IsFreeCell(Tile tile)
        {
            return Board.GetTileBackColor(tile) != 'B';
        }

        public static void FindSP(Graph graph)
        {
            try
            {
                if (graph == null || graph.Size() == 0)
                {
                    throw new ArgumentException("empty or null graph");
                }
                if (graph.Size() == 1)
                {
                    throw new ArgumentException("graph's size must be greater than 1");
                }
                if (startVertex == -1)
                {
                    throw new ArgumentException("Start vertex not found");
                }
                if (endVertex == -1)
                {
                    throw new ArgumentException("End vertex not found");
                }
            }
            catch(ArgumentException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            if (!isStartVertexEdgeAvailable)
            {
                MessageBox.Show("No path available");
                return;
            }

            Dictionary<int, int> sonToParent = BFS(graph, startVertex, endVertex);
            if (Object.Equals(sonToParent, default(Dictionary<int, int>)))
            {
                MessageBox.Show("No path available");
                return;
            }
            Stack<int> path = new();
            for (int son = endVertex; son != startVertex; son = sonToParent[son])
            {
                path.Push(son);
            }
            path.Push(startVertex);
            while (!(path.Count == 0))
            {
                DrawPath(path.Pop());
            }
        }
        private static void DrawPath(int n)
        {
            for (int x = 0; x < Board.Tiles.GetLength(0); ++x)
            {
                for (int y = 0; y < Board.Tiles.GetLength(1); ++y)
                {
                    if (Board.Tiles[x, y].Id.Equals(n))
                    {
                        if (Board.GetTileBackColor(Board.Tiles[x, y]) != 'G' && Board.GetTileBackColor(Board.Tiles[x, y]) != 'R')
                        {
                            Board.Tiles[x, y].Panel.BackColor = Color.Purple;
                        }
                    }
                }
            }
        }
        private static Dictionary<int, int> BFS(Graph g, int startVertex2, int endVertex2)
        {
            Queue<int> q = new();
            HashSet<int> marked = new();
            Dictionary<int, int> sonToParent = new();
            q.Enqueue(startVertex2);
            while (!(q.Count == 0))
            {
                int v = q.Dequeue();
                foreach (int s in g.Adj(v))
                {
                    if (!marked.Contains(s))
                    {
                        marked.Add(s);
                        sonToParent.Add(s, v);
                        if (s == endVertex2)
                        {
                            return sonToParent;
                        }
                        q.Enqueue(s);
                    }
                }
            }
            return null;
        }
    }
}