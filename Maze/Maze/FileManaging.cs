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
        public static Tile[,] Tiles { get; set; }
        public static void Save()
        {
            char[,] board = new char[Board.BoardSize.Item1, Board.BoardSize.Item2];
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Maze File|*.maz",
                Title = "Save Maze File",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                OverwritePrompt = true
        };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != string.Empty)
                {
                    StreamWriter streamWriter = new(saveFileDialog.FileName);
                    for (int x = 0; x < Board.Tiles.GetLength(0); x++)
                    {
                        for (int y = 0; y < Board.Tiles.GetLength(1); y++)
                        {
                            board[x, y] = Board.GetTileBackColor(Board.Tiles[x, y]);
                        }
                    }
                    for (int x = 0; x < board.GetLength(0); x++)
                    {
                        string output = string.Empty;
                        for (int y = 0; y < board.GetLength(1); y++)
                        {
                            output += board[x, y];
                        }
                    }
                    streamWriter.Close();
                }
            } 
        }
        public static bool Load()
        {
            using OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "Maze File (*.maz)|",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Tiles = PopulatePanels(openFileDialog.FileName);
                return true;
            }
            return false;
        }
        private static Tile[,] PopulatePanels(string path)
        {
            char[] charArr;
            int counter = 1;
            Board.StartPointAvailable = false;
            Board.EndPointAvailable = false;
            using StreamReader sr = new(path);
            string line = sr.ReadLine();
            int cols = line.Length;
            var rows = File.ReadLines(path).Count();
            Tiles = new Tile[rows, cols];
            Board.PanelSize = new Size(25, 25);
            Board.BoardSize = (rows, cols);

            for (int x = 0; x < Tiles.GetLength(0); x++)
            {
                charArr = line.ToCharArray();
                for (int y = 0; y < Tiles.GetLength(1); y++)
                {
                    Panel panel = new()
                    {
                        Size = Board.PanelSize
                    };
                    if (charArr[y] == 'G')
                    {
                        Board.StartPointAvailable = true;
                        panel.BackColor = Color.Green;
                    }
                    else if (charArr[y] == 'R')
                    {
                        Board.EndPointAvailable = true;
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
                    else if (charArr[y] == 'P')
                    {
                        panel.BackColor = Color.White;
                    }
                    else
                    {
                        throw new InvalidOperationException("Invalid BackColor transfer operation");
                    }
                    panel.Left = 25 * x + (1 * x);
                    panel.Top = 25 * y + (1 * y);
                    Tile tile = new(counter++, panel);
                    Tiles[x, y] = tile;
                }
                line = sr.ReadLine();
            }
            return Tiles;
        }
    }
}