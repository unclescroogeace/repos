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
    public partial class BudgetCalculator : Form
    {
        public BudgetCalculator()
        {
            InitializeComponent();
            LoadIncomeSavings();
            LoadExpenses();
        }

        private void LoadIncomeSavings()
        {
            string connectionString = "Server=localhost;Database=BudgetCalculator;Trusted_Connection=True;";
            using SqlConnection connection = new(connectionString);
            string queryString = "SELECT Amount FROM Money";
            SqlCommand command = new(queryString, connection);
            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                decimal[] decimalArray = new decimal[2];
                int i = 0;
                while (reader.Read())
                {
                    if (!decimal.TryParse(reader[0].ToString(), out decimalArray[i]))
                    {
                        MessageBox.Show("Invalid income/savings");
                    }
                    i++;
                }
                reader.Close();
                textBoxIncome.Text = Math.Round(decimalArray[0], 2).ToString();
                textBoxSavings.Text = Math.Round(decimalArray[1], 2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void LoadExpenses()
        {
            string connectionString = "Server=localhost;Database=BudgetCalculator;Trusted_Connection=True;";
            using SqlConnection connection = new(connectionString);
            string queryString = "SELECT Amount FROM Expense";
            SqlCommand command = new(queryString, connection);
            try
            {
                decimal total = 0;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                decimal[] decimalArray = new decimal[10];
                int i = 0;
                while (reader.Read())
                {
                    if(!decimal.TryParse(reader[0].ToString(), out decimalArray[i]))
                    {
                        MessageBox.Show("Ivvalid expense");
                    }
                    total += decimalArray[i];
                    i++;
                }
                reader.Close();
                textBoxHousing.Text = Math.Round(decimalArray[0], 2).ToString();
                textBoxTransportation.Text = Math.Round(decimalArray[1], 2).ToString();
                textBoxTaxes.Text = Math.Round(decimalArray[2], 2).ToString();
                textBoxUtilities.Text = Math.Round(decimalArray[3], 2).ToString();
                textBoxVices.Text = Math.Round(decimalArray[4], 2).ToString();
                textBoxFood.Text = Math.Round(decimalArray[5], 2).ToString();
                textBoxInsurance.Text = Math.Round(decimalArray[6], 2).ToString();
                textBoxEntertainment.Text = Math.Round(decimalArray[7], 2).ToString();
                textBoxEducation.Text = Math.Round(decimalArray[8], 2).ToString();
                textBoxMiscellaneous.Text = Math.Round(decimalArray[9], 2).ToString();
                labelTotalExpensesAmount.Text = Math.Round(total, 2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        private void ButtonIncomeSet_Click(object sender, EventArgs e)
        {

        }
    }
}