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
    public partial class BudgetCalculator : Form
    {
        public BudgetCalculator()
        {
            InitializeComponent();
            comboBoxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCurrency.Items.Add("USD");
            comboBoxCurrency.Items.Add("EUR");
            comboBoxCurrency.Items.Add("BGN");
            comboBoxCurrency.SelectedIndex = 0;
        }

        private void ButtonAddIncome_Click(object sender, EventArgs e)
        {
            Income IncomeForm = new(comboBoxCurrency.SelectedItem.ToString());
            IncomeForm.ShowDialog();
        }
    }
}
