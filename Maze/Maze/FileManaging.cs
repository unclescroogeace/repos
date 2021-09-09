using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public class FileManaging
    {
        public static void Save()
        {
            char[,] board = new char[Board.boardSize.Item1,Board.boardSize.Item2];

            for (int x = 0; x <= Board.boardPanels.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= Board.boardPanels.GetUpperBound(1); y++)
                {
                    board[x, y] = getBackColor(Board.boardPanels[x, y]);
                }
            }

            StreamWriter streamWriter = new StreamWriter("bird.txt");
            string output = string.Empty;
            for (int x = 0; x <= board.GetUpperBound(0); x++)
            {
                output = string.Empty;
                for (int y = 0; y <= board.GetUpperBound(1); y++)
                {
                    output += board[x, y];
                }
                streamWriter.WriteLine(output);
            }
            streamWriter.Close();

        }

        public static Panel[,] Load()
        {
            StreamReader sr = new StreamReader("bird.txt");
            string line;
            int n;
            char[] charArr;
            line = sr.ReadLine();
            n = line.Length;
            Panel[,] panels = new Panel[n,n];

            for (int x = 0; x <= panels.GetUpperBound(0); x++)
            {
                charArr= line.ToCharArray();
                for (int y = 0; y <= panels.GetUpperBound(1); y++)
                {
                    Panel panel = new Panel();
                    panel.Size = Board.panelSize;
                    if (charArr[y] == 'G')
                    {
                        panel.BackColor = Color.Green;
                    }
                    else if (charArr[y] == 'R')
                    {
                        panel.BackColor = Color.Red;
                    }
                    else if (charArr[y] == 'B')
                    {
                        panel.BackColor = Color.Black;
                    }
                    else if (charArr[y] == 'W')
                    {
                        panel.BackColor = Color.White;
                    }
                    else
                    {
                        throw new InvalidOperationException("Invalid transfer operation");
                    }
                    panel.Left = 25 * x + (1 * x);
                    panel.Top = 25 * y + (1 * y);
                    panels[x, y] = panel;
                }
                line = sr.ReadLine();
            }
            return panels;
        }

        private static char getBackColor(Panel panel)
        {
            if (panel.BackColor == Color.Green)
            {
                return 'G';
            }
            else if (panel.BackColor == Color.Red)
            {
                return 'R';
            }
            else if(panel.BackColor == Color.White)
            {
                return 'W';
            }
            else if (panel.BackColor == Color.Black)
            {
                return 'B';
            }
            else
            {
                throw new InvalidOperationException("Invalid transfer operation");
            }
        }
    }
}
