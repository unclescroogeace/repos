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
        public static(int, int) boardSize { get; set; }
        //private static int[,] boardMatrix = new int[boardSize.Item1, boardSize.Item2];
        public static Panel[,] boardPanels;

        public static void GenerateBoardPanels()
        {
            boardPanels = new Panel[boardSize.Item1, boardSize.Item2];
            for (int x = 0; x <= boardPanels.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= boardPanels.GetUpperBound(1); y++)
                {
                    boardPanels[x, y] = new Panel();
                    boardPanels[x, y].Size = new Size(20, 20);
                }
            }
        }
    }
}
