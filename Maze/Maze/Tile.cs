using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public class Tile
    {
        public enum Types
        {
            Wall = 0,
            Air = 1,
            StartPoint = 2,
            EndPoint = 3,
            Path = 4
        }
        public int Id { get; set; }
        public Panel Panel { get; set; }
        public int Type { get; set; }
        public Tile(int id, Panel panel)
        {
            Id = id;
            Panel = panel;
        }
    }

    public static class TileTypes
    {
        public const int Wall = 0;
        public const int Air = 1;
        public const int Start = 2;
        public const int End = 3;
        public const int Path = 4;
    }
}