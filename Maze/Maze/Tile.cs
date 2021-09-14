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
        public int Id { get; set; }
        public Panel Panel { get; set; }
        public int Type { get; set; }
        public Tile(int id, Panel panel)
        {
            Id = id;
            Panel = panel;
        }
    }
}