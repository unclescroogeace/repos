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
                Title = "Save Maze File"
            };
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != string.Empty)
            {
                StreamWriter streamWriter = new(saveFileDialog.FileName);
                for (int x = 0; x <= Board.Tiles.GetUpperBound(0); x++)
                {
                    for (int y = 0; y <= Board.Tiles.GetUpperBound(1); y++)
                    {
                        board[x, y] = Board.GetTileBackColor(Board.Tiles[x, y]);
                    }
                }
                for (int x = 0; x <= board.GetUpperBound(0); x++)
                {
                    string output = string.Empty;
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
            using OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = @"C:\Users\Krasimir Kostadinov\Documents";
            openFileDialog.Filter = "Maze File (*.maz)|";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Tiles = PopulatePanels(openFileDialog.FileName);
                return true;
            }
            return false;
        }
        private static Tile[,] PopulatePanels(string path)
        {
            Board.StartPointAvailable = false;
            Board.EndPointAvailable = false;
            using StreamReader sr = new(path);
            int size;
            char[] charArr;
            string line = sr.ReadLine();
            size = line.Length;
            //Not proper size array for N x M
            var rows = File.ReadLines(path).Count();
            Tiles = new Tile[rows, size];
            Board.PanelSize = new Size(25, 25);
            Board.BoardSize = (rows, size);
            int counter = 1;
            for (int x = 0; x <= Tiles.GetUpperBound(0); x++)
            {
                //Error to fix
                charArr = line.ToCharArray();
                for (int y = 0; y <= Tiles.GetUpperBound(1); y++)
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