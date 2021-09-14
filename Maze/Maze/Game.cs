using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        public Panel MainPanel = new();
        private Color SelectedColor = Color.Empty;
        private void EmptyMainPanel()
        {
            foreach (Control item in MainPanel.Controls.OfType<Panel>().ToList())
            {
                MainPanel.Controls.Remove(item);
            }
        }
        private void MainPanelRenewer()
        {
            EmptyMainPanel();
            MainPanel.Size = new Size(Board.PanelSize.Width * Board.BoardSize.Item1 + Board.BoardSize.Item1 - 1,
                                Board.PanelSize.Height * Board.BoardSize.Item2 + Board.BoardSize.Item2 - 1);
            MainPanel.BackColor = Color.White;
            MainPanel.Top = 100;
        }
        private void AddClickEventToPanel(Panel panel)
        {
            panel.Click += Panel_Click;
            MainPanel.Controls.Add(panel);
        }
        private void AddPanelsToForm()
        {
            MainPanelRenewer();
            Board.StartPointAvailable = false;
            Board.EndPointAvailable = false;
            AddPanels();
        }
        private void AddPanelsToFormByLoading(Tile[,] tiles)
        {
            MainPanelRenewer();
            Board.Tiles = tiles;
            AddPanels();
        }
        private void AddPanels()
        {
            for (int x = 0; x < Board.Tiles.GetLength(0); x++)
            {
                for (int y = 0; y < Board.Tiles.GetLength(1); y++)
                {
                    AddClickEventToPanel(Board.Tiles[x, y].Panel);
                }
            }
            Controls.Add(MainPanel);
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            if (SelectedColor == Color.Green)
            {
                if (Board.StartPointAvailable == true)
                {
                    lblInfo.Text = "You can have only 1 start point";
                }
                else if ((sender as Panel).BackColor == Color.Red)
                {
                    Board.EndPointAvailable = false;
                    Board.StartPointAvailable = true;
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
                else
                {
                    Board.StartPointAvailable = true;
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
            }
            else if (SelectedColor == Color.Red)
            {
                if (Board.EndPointAvailable == true)
                {
                    lblInfo.Text = "You cna have only 1 end point";
                }
                else if ((sender as Panel).BackColor == Color.Green)
                {
                    Board.StartPointAvailable = false;
                    Board.EndPointAvailable = true;
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
                else
                {
                    Board.EndPointAvailable = true;
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
            }
            else if (SelectedColor == Color.Black)
            {
                if ((sender as Panel).BackColor == Color.Green)
                {
                    Board.StartPointAvailable = false;
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
                else if ((sender as Panel).BackColor == Color.Red)
                {
                    Board.EndPointAvailable = false;
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
                else
                {
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
            }
            else if (SelectedColor == Color.White)
            {
                if ((sender as Panel).BackColor == Color.Green)
                {
                    Board.StartPointAvailable = false;
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
                else if ((sender as Panel).BackColor == Color.Red)
                {
                    Board.EndPointAvailable = false;
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
                else
                {
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
            }
        }
        private void BtnGenerateBoard_Click(object sender, EventArgs e)
        {
            _ = int.TryParse(tbX.Text, out int x);
            _ = int.TryParse(tbY.Text, out int y);
            if (x > 0 && y > 0)
            {
                Board.BoardSize = (x, y);
                Board.PanelSize = new Size(25, 25);
                Board.GenerateBoardPanels();
                AddPanelsToForm();
            }
        }
        private void BtnColorBlack_Click(object sender, EventArgs e)
        {
            SelectedColor = (sender as Button).BackColor;
        }
        private void BtnColorWhite_Click(object sender, EventArgs e)
        {
            SelectedColor = (sender as Button).BackColor;
        }
        private void BtnColorGreen_Click(object sender, EventArgs e)
        {
            SelectedColor = (sender as Button).BackColor;
        }
        private void BtnColorRed_Click(object sender, EventArgs e)
        {
            SelectedColor = (sender as Button).BackColor;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Board.Tiles != null)
            {
                FileManaging.Save();
            }
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (FileManaging.Load())
            {
                AddPanelsToFormByLoading(FileManaging.Tiles);
            }
        }
        private void BtnFindSP_Click(object sender, EventArgs e)
        {
            Board.ClearPath();
            if (Board.StartPointAvailable == true && Board.EndPointAvailable == true)
            {
                Graph graph = PathFinder.CreateGraph(Board.Tiles);
                PathFinder.FindShortestPath(graph);
            }
            else
            {
                lblInfo.Text = "No start or end point";
            }
        }
        private void BtnClearPath_Click(object sender, EventArgs e)
        {
            Board.ClearPath();
        }
        private void BtnPreLoadedMap_Click(object sender, EventArgs e)
        {
            char[,] preLoaded = { { 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'W', 'B', 'B', 'B', 'B', 'W', 'W', 'W', 'W', 'W'
                },
                                 { 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'B', 'B', 'W', 'B'
                },
                                 { 'W', 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'W', 'W', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'B', 'W', 'B', 'B'
                },
                                 { 'W', 'W', 'B', 'B', 'B', 'B', 'W', 'W', 'W', 'W', 'W', 'B', 'W', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'W', 'W', 'B', 'B', 'B'
                },
                                 { 'B', 'W', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'B'
                },
                                 { 'B', 'W', 'B', 'B', 'G', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'W', 'B', 'B', 'B', 'B'
                },
                                 { 'B', 'W', 'B', 'B', 'W', 'B', 'W', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'W', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'B'
                },
                                 { 'B', 'W', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'W', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'W', 'W', 'W', 'W', 'B'
                },
                                 { 'B', 'W', 'W', 'W', 'W', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'W'
                },
                                 { 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'W', 'W', 'B', 'B', 'B', 'B', 'W', 'W', 'B', 'B', 'B', 'B', 'B', 'W'
                },
                                 { 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'W', 'B', 'W', 'B', 'B', 'B', 'W', 'W', 'B'
                },
                                 { 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'W', 'B', 'B', 'W', 'W', 'B', 'B', 'B', 'W', 'B', 'W', 'B', 'B', 'W', 'B', 'B', 'B'
                },
                                 { 'B', 'W', 'W', 'W', 'W', 'W', 'B', 'W', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'B', 'B', 'B'
                },
                                 { 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'B'
                },
                                 { 'B', 'B', 'W', 'B', 'W', 'W', 'W', 'B', 'W', 'W', 'W', 'W', 'W', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B'
                },
                                 { 'B', 'B', 'B', 'W', 'W', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'W', 'B', 'B', 'B', 'B', 'B', 'B', 'B'
                },
                                 { 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'B'
                },
                                 { 'B', 'B', 'B', 'B', 'W', 'W', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'W', 'W', 'W', 'W', 'B'
                },
                                 { 'B', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'W', 'B', 'W', 'W', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'B'
                },
                                 { 'B', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'W', 'B'
                },
                                 { 'B', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'W', 'W', 'W', 'B', 'B', 'W', 'B', 'B', 'B', 'R', 'B', 'W', 'B'
                },
                                 { 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'B', 'B', 'W', 'B', 'W', 'B'
                },
                                 { 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'B', 'W', 'W', 'B', 'W', 'B'
                },
                                 { 'B', 'B', 'W', 'W', 'W', 'W', 'B', 'W', 'W', 'B', 'B', 'W', 'W', 'B', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'B', 'B', 'W', 'B'
                },
                                 { 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'B', 'W', 'W', 'W', 'B', 'B', 'W', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'W', 'W', 'W', 'B'
                }
            };
            MainPanelRenewer();
            Board.BoardSize = (25, 25);
            int counter = 1;
            Board.StartPointAvailable = false;
            Board.EndPointAvailable = false;
            Board.PanelSize = new Size(25, 25);
            Tile[,] tiles = new Tile[25, 25];
            for (int x = 0; x < Board.BoardSize.Item1; x++)
            {
                for (int y = 0; y < Board.BoardSize.Item2; y++)
                {
                    Panel panel = new()
                    {
                        Size = Board.PanelSize
                    };
                    if (preLoaded[x, y] == 'G')
                    {
                        Board.StartPointAvailable = true;
                        panel.BackColor = Color.Green;
                    }
                    else if (preLoaded[x, y] == 'R')
                    {
                        Board.EndPointAvailable = true;
                        panel.BackColor = Color.Red;
                    }
                    else if (preLoaded[x, y] == 'B')
                    {
                        panel.BackColor = Color.Black;
                    }
                    else if (preLoaded[x, y] == 'W')
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
                    tiles[x, y] = tile;
                }
            }
            AddPanelsToFormByLoading(tiles);
        }
    }
}