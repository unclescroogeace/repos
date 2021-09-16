using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetCalculator
{
    public partial class Income : Form
    {
        public Income(string currency)
        {
            InitializeComponent();
            ChangeCurrency(currency);
        }

        private void ChangeCurrency(string currency)
        {
            foreach(Control c in Controls)
            {
                if (c.Name.ToString().Contains("labelCurrency"))
                {
                    c.Text = currency;
                }
            }
        }
    }
}
