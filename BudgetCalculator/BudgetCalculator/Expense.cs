using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetCalculator
{
    public partial class Expense : Form
    {
        public Expense(string currency)
        {
            InitializeComponent();
            comboBoxExpenseType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExpenseType.Items.Insert(0, "-- Select --");
            comboBoxExpenseType.Items.Add("Housing");
            comboBoxExpenseType.Items.Add("Transportation");
            comboBoxExpenseType.Items.Add("Taxes");
            comboBoxExpenseType.Items.Add("Utilities and Other Household Operational Costs");
            comboBoxExpenseType.Items.Add("Food");
            comboBoxExpenseType.Items.Add("Social Security Contributions, Personal Insurance and Pensions");
            comboBoxExpenseType.Items.Add("Debt Payments or Savings");
            comboBoxExpenseType.Items.Add("Healthcare");
            comboBoxExpenseType.Items.Add("Entertainment");
            comboBoxExpenseType.Items.Add("Cash Contributions");
            comboBoxExpenseType.Items.Add("Apparel and Services");
            comboBoxExpenseType.Items.Add("Education");
            comboBoxExpenseType.Items.Add("Vices");
            comboBoxExpenseType.Items.Add("Miscellaneous");
            comboBoxExpenseType.Items.Add("Personal Care");
            comboBoxExpenseType.SelectedIndex = 0;
            labelCurrency.Text = currency;
        }

        private static bool ExpenseTypeNotDefault(int index)
        {
            if (index > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private decimal MoreThanZero(string amount)
        {
            if (string.IsNullOrEmpty(amount))
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(textBoxAmount.Text);
            }
        }

        private void ButtonAddExpense_Click(object sender, EventArgs e)
        {
            int selectedTypeIndex;
            string connectionString = "Server=localhost;Database=BudgetCalculator;Trusted_Connection=True;";
            string queryString = "INSERT INTO Expense(TypeId, Amount, Description) VALUES(@ExpenseTypeIndex, @Amount, @Description)";
            using SqlConnection connection = new(connectionString);
            SqlCommand command = new(queryString, connection);
            if(ExpenseTypeNotDefault(comboBoxExpenseType.SelectedIndex))
            {
                selectedTypeIndex = comboBoxExpenseType.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Invalid expense type");
                return;
            }
            command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = MoreThanZero(textBoxAmount.Text);
            command.Parameters.Add("@ExpenseTypeIndex", SqlDbType.Int).Value = selectedTypeIndex;
            command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = richTextBoxDescription.Text;
            connection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            Close();
        }
    }
}
