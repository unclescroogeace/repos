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
        private Color SelectedColor = Color.Empty;
        private bool StartPointAvailable = false;
        private bool EndPointAvailable = false;
        public Panel MainPanel = new();
        private void EmptyMainPanel()
        {
            foreach (Control item in MainPanel.Controls.OfType<Panel>().ToList())
            {
                MainPanel.Controls.Remove(item);
            }
        }
        private void AddClickEventToPanel(Panel panel)
        {
            panel.Click += Panel_Click;
            MainPanel.Controls.Add(panel);
        }
        private void MainPanelRenewer()
        {
            EmptyMainPanel();
            MainPanel.Size = new Size(Board.PanelSize.Width * Board.BoardSize.Item1 + Board.BoardSize.Item1 - 1,
                                Board.PanelSize.Height * Board.BoardSize.Item2 + Board.BoardSize.Item2 - 1);
            MainPanel.BackColor = Color.White;
            MainPanel.Top = 100;
        }
        private void AddPanelsToForm()
        {
            MainPanelRenewer();
            StartPointAvailable = false;
            EndPointAvailable = false;
            for (int x = 0; x <= Board.Tiles.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= Board.Tiles.GetUpperBound(1); y++)
                {
                    AddClickEventToPanel(Board.Tiles[x, y].Panel);
                }
            }
            Controls.Add(MainPanel);
        }
        private void AddPanelsToFormByLoading(Tile[,] tiles)
        {
            MainPanelRenewer();
            for (int x = 0; x <= tiles.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= tiles.GetUpperBound(1); y++)
                {
                    AddClickEventToPanel(tiles[x, y].Panel);
                }
            }
            Controls.Add(MainPanel);
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            if (SelectedColor == Color.Green)
            {
                if (StartPointAvailable == true)
                {
                    lblInfo.Text = "You can have only 1 start point";
                }
                else
                {
                    StartPointAvailable = true;
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
            }
            else if (SelectedColor == Color.Red)
            {
                if (EndPointAvailable == true)
                {
                    lblInfo.Text = "You cna have only 1 end point";
                }
                else
                {
                    EndPointAvailable = true;
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
            }
            else if (SelectedColor == Color.Black)
            {
                if ((sender as Panel).BackColor == Color.Green)
                {
                    StartPointAvailable = false;
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
                else if ((sender as Panel).BackColor == Color.Red)
                {
                    EndPointAvailable = false;
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
                    StartPointAvailable = false;
                    (sender as Panel).BackColor = SelectedColor;
                    lblInfo.Text = string.Empty;
                }
                else if ((sender as Panel).BackColor == Color.Red)
                {
                    EndPointAvailable = false;
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
    }
}