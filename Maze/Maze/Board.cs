using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Maze
{

    class Board
    {
        public static (int, int) BoardSize { get; set; }
        public static Panel[,] BoardPanels;
        public static Size PanelSize { get; set; }
        public static void GenerateBoardPanels()
        {
            BoardPanels = new Panel[BoardSize.Item1, BoardSize.Item2];
            for (int x = 0; x <= BoardPanels.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= BoardPanels.GetUpperBound(1); y++)
                {
                    BoardPanels[x, y] = new Panel
                    {
                        Size = PanelSize,
                        BackColor = Color.Black,
                        Left = 25 * x + (1 * x),
                        Top = 25 * y + (1 * y)
                    };
                }
            }
        }
    }
}