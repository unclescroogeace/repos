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
        public static Panel[,] Panels { get; set; }
        public static void Save()
        {
            char[,] board = new char[Board.BoardSize.Item1, Board.BoardSize.Item2];
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Maze File|*.maz";
            saveFileDialog.Title = "Save Maze File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != string.Empty)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                string output = string.Empty;

                for (int x = 0; x <= Board.BoardPanels.GetUpperBound(0); x++)
                {
                    for (int y = 0; y <= Board.BoardPanels.GetUpperBound(1); y++)
                    {
                        board[x, y] = GetBackColor(Board.BoardPanels[x, y]);
                    }
                }
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

        }
        public static bool Load()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Krasimir Kostadinov\Documents";
                openFileDialog.Filter = "Maze File (*.maz)|";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Panels = PopulatePanels(openFileDialog.FileName);
                    return true;
                }
                return false;
            }
        }

        private static Panel[,] PopulatePanels(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                int size;
                char[] charArr;
                string line = sr.ReadLine();
                size = line.Length;
                Panels = new Panel[size, size];
                Board.PanelSize = new Size(25, 25);
                Board.BoardSize = (size, size);

                for (int x = 0; x <= Panels.GetUpperBound(0); x++)
                {
                    charArr = line.ToCharArray();
                    for (int y = 0; y <= Panels.GetUpperBound(1); y++)
                    {
                        Panel panel = new Panel();
                        panel.Size = Board.PanelSize;
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
                            throw new InvalidOperationException("Invalid BackColor transfer operation");
                        }
                        panel.Left = 25 * x + (1 * x);
                        panel.Top = 25 * y + (1 * y);
                        Panels[x, y] = panel;
                    }
                    line = sr.ReadLine();
                }
                return Panels;
            }
        }

        private static char GetBackColor(Panel panel)
        {
            if (panel.BackColor == Color.Green)
            {
                return 'G';
            }
            else if (panel.BackColor == Color.Red)
            {
                return 'R';
            }
            else if (panel.BackColor == Color.White)
            {
                return 'W';
            }
            else if (panel.BackColor == Color.Black)
            {
                return 'B';
            }
            else
            {
                throw new InvalidOperationException("Invalid BackColor transfer operation");
            }
        }
    }
}
