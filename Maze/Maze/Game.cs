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
        private Color SelectedColor = Color.Black;
        private bool StartPointAvailable = false;
        private bool EndPointAvailable = false;
        public Panel MainPanel = new Panel();
        public Game()
        {
            InitializeComponent();
        }

        private void EmptyMainPanel()
        {
            foreach (Control item in MainPanel.Controls.OfType<Panel>().ToList())
            {
                MainPanel.Controls.Remove(item);
            }
        }

        private void AddPanelsToForm()
        {
            EmptyMainPanel();
            StartPointAvailable = false;
            EndPointAvailable = false;
            MainPanel.Size = new Size(Board.panelSize.Width * Board.boardSize.Item1 + Board.boardSize.Item1 - 1,
                                Board.panelSize.Height * Board.boardSize.Item2 + Board.boardSize.Item2 - 1);
            MainPanel.BackColor = Color.White;
            MainPanel.Top = 100;
            for (int x = 0; x <= Board.boardPanels.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= Board.boardPanels.GetUpperBound(1); y++)
                {
                    Board.boardPanels[x, y].Click += p_Click;
                    MainPanel.Controls.Add(Board.boardPanels[x, y]);
                }
            }
            Controls.Add(MainPanel);
        }

        private void AddClickEventToPanel(Panel panel)
        {
            panel.Click += p_Click;
            MainPanel.Controls.Add(panel);
        }

        private void AddPanelsToFormByLoading(Panel[,] panels)
        {
            EmptyMainPanel();
            MainPanel.Size = new Size(Board.panelSize.Width * Board.boardSize.Item1 + Board.boardSize.Item1 - 1,
                                Board.panelSize.Height * Board.boardSize.Item2 + Board.boardSize.Item2 - 1);
            MainPanel.BackColor = Color.White;
            MainPanel.Top = 100; 
            for (int x = 0; x <= panels.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= panels.GetUpperBound(1); y++)
                {
                    AddClickEventToPanel(panels[x, y]);
                }
            }
            Controls.Add(MainPanel);
        }

        void p_Click(object sender, EventArgs e)
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

        private void btnGenerateBoard_Click(object sender, EventArgs e)
        {
            int x, y;
            int.TryParse(tbX.Text, out x);
            int.TryParse(tbY.Text, out y);
            if (x > 0 && y > 0)
            {
                Board.boardSize = (x, y);
                Board.panelSize = new Size(25, 25);
                Board.GenerateBoardPanels();
                AddPanelsToForm();
            }
        }

        private void btnColorBlack_Click(object sender, EventArgs e)
        {
            SelectedColor = (sender as Button).BackColor;
        }

        private void btnColorWhite_Click(object sender, EventArgs e)
        {
            SelectedColor = (sender as Button).BackColor;
        }

        private void btnColorGreen_Click(object sender, EventArgs e)
        {
            SelectedColor = (sender as Button).BackColor;
        }

        private void btnColorRed_Click(object sender, EventArgs e)
        {
            SelectedColor = (sender as Button).BackColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Board.boardPanels != null)
            {
                FileManaging.Save();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (FileManaging.Load())
            {
                AddPanelsToFormByLoading(FileManaging.Panels);
            }
        }
    }
}
