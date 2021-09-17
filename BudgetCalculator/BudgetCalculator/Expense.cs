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
        public Expense()
        {
            InitializeComponent();
            
        }

        private void ButtonAddExpense_Click(object sender, EventArgs e)
        {
            //int selectedTypeIndex;
            //string connectionString = "Server=localhost;Database=BudgetCalculator;Trusted_Connection=True;";
            //string queryString = "INSERT INTO Expense(TypeId, Amount, Description) VALUES(@ExpenseTypeIndex, @Amount, @Description)";
            //using SqlConnection connection = new(connectionString);
            //SqlCommand command = new(queryString, connection);
            //if(ExpenseTypeNotDefault(comboBoxExpenseType.SelectedIndex))
            //{
            //    selectedTypeIndex = comboBoxExpenseType.SelectedIndex;
            //}
            //else
            //{
            //    MessageBox.Show("Invalid expense type");
            //    return;
            //}
            //command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = MoreThanZero(textBoxAmount.Text);
            //command.Parameters.Add("@ExpenseTypeIndex", SqlDbType.Int).Value = selectedTypeIndex;
            //command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = richTextBoxDescription.Text;
            //connection.Open();
            //try
            //{
            //    command.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //connection.Close();
            //Close();
        }
    }
}
