using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class PathFinder
    {

        private static int startVertex;
        private static int endVertex;
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
                    if (col + c >= Board.BoardSize.Item2 || row + r >= Board.BoardSize.Item1)
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
            if (graph == null || graph.Size() == 0)
            {
                throw new ArgumentException("empty or null graph");
            }
            if (graph.Size() == 1)
            {
                throw new ArgumentException(
                        "graph's size must be greater than 1");
            }
            if (startVertex == -1)
            {
                throw new ArgumentException("Start vertex not found");
            }
            if (endVertex == -1)
            {
                throw new ArgumentException("End vertex not found");
            }

            Dictionary<int, int> sonToParent = BFS(graph, startVertex, endVertex);
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
            int w = Board.Tiles.GetLength(0); // width
            int h = Board.Tiles.GetLength(1); // height

            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
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