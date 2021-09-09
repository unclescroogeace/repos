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
        public static int width = boardSize.Item1;
        public static int height = boardSize.Item2;
        public static Panel[,] boardPanels;
        public static Size panelSize { get; set; }
        public static void GenerateBoardPanels()
        {
            boardPanels = new Panel[boardSize.Item1, boardSize.Item2];
            for (int x = 0; x <= boardPanels.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= boardPanels.GetUpperBound(1); y++)
                {
                    boardPanels[x, y] = new Panel();
                    boardPanels[x, y].Size = panelSize;
                    boardPanels[x, y].BackColor = Color.Black;
                    boardPanels[x, y].Left = 25 * x + (1 * x);
                    boardPanels[x, y].Top = 25 * y + (1 * y);
                }
            }
        }
    }
}
