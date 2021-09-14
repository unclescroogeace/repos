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
        public static bool StartPointAvailable { get; set; } = false;
        public static bool EndPointAvailable { get; set; } = false;
        public static Tile[,] Tiles;
        public static Size PanelSize { get; set; }
        public static void GenerateBoardPanels()
        {
            int counter = 1;
            Tiles = new Tile[BoardSize.Item1, BoardSize.Item2];
            for (int x = 0; x <= Tiles.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= Tiles.GetUpperBound(1); y++)
                {
                    Tiles[x, y] = new(counter++, new Panel
                    {
                        Size = PanelSize,
                        BackColor = Color.Black,
                        Left = 25 * x + (1 * x),
                        Top = 25 * y + (1 * y)
                    });
                }
            }
        }
        public static char GetTileBackColor(Tile tile)
        {
            if (tile.Panel.BackColor == Color.Green)
            {
                return 'G';
            }
            else if (tile.Panel.BackColor == Color.Red)
            {
                return 'R';
            }
            else if (tile.Panel.BackColor == Color.White)
            {
                return 'W';
            }
            else if (tile.Panel.BackColor == Color.Black)
            {
                return 'B';
            }
            else if (tile.Panel.BackColor == Color.Purple)
            {
                return 'P';
            }
            else
            {
                throw new InvalidOperationException("Invalid BackColor transfer operation");
            }
        }
        public static int GetStartPointId()
        {
            for (int x = 0; x <= Tiles.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= Tiles.GetUpperBound(1); y++)
                {
                    if (GetTileBackColor(Tiles[x, y]) == 'G')
                    {
                        return Tiles[x, y].Id;
                    }
                }
            }
            return 0;
        }
        public static int GetEndPointId()
        {
            for (int x = 0; x <= Tiles.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= Tiles.GetUpperBound(1); y++)
                {
                    if (GetTileBackColor(Tiles[x, y]) == 'R')
                    {
                        return Tiles[x, y].Id;
                    }
                }
            }
            return 0;
        }

        public static void ClearPath()
        {
            if (!Object.Equals(Tiles, default(Tile[,])))
            {
                for (int x = 0; x <= Tiles.GetUpperBound(0); x++)
                {
                    for (int y = 0; y <= Tiles.GetUpperBound(1); y++)
                    {
                        if (Tiles[x, y].Panel.BackColor == Color.Purple)
                        {
                            Tiles[x, y].Panel.BackColor = Color.White;
                        }
                    }
                }
            }
        }
    }
}