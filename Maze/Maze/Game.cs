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

        private void AddPanelsToForm()
        {
            for (int x = 0; x <= Board.boardPanels.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= Board.boardPanels.GetUpperBound(1); y++)
                {
                    Controls.Add(Board.boardPanels[x, y]);
                }
            }
        }

        private void btnGenerateBoard_Click(object sender, EventArgs e)
        {
            int x, y;
            Int32.TryParse(tbX.Text, out x);
            Int32.TryParse(tbY.Text, out y);
            if (x > 0 && y > 0)
            {
                Board.boardSize = (x, y);
                Board.GenerateBoardPanels();
                AddPanelsToForm();
            }
        }
    }
}
