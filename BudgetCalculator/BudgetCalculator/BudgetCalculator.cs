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
        private decimal ExpenseValue = 0;
        private decimal IncomeValue = 0;
        public BudgetCalculator()
        {
            InitializeComponent();
            LoadIncome();
            LoadGoals();
            LoadExpenses();
            CalculateSavings();
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
                ExpenseValue = total;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        private void LoadIncome()
        {
            string connectionString = "Server=localhost;Database=BudgetCalculator;Trusted_Connection=True;";
            using SqlConnection connection = new(connectionString);
            string queryString = "SELECT Amount FROM Money WHERE Id = 1";
            SqlCommand command = new(queryString, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                decimal value = 0;
                int i = 0;
                while (reader.Read())
                {
                    if (!decimal.TryParse(reader[0].ToString(), out value))
                    {
                        MessageBox.Show("Ivvalid expense");
                    }
                    i++;
                }
                reader.Close();
                textBoxIncome.Text = Math.Round(value, 2).ToString();
                IncomeValue = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        private void LoadGoals()
        {
            string connectionString = "Server=localhost;Database=BudgetCalculator;Trusted_Connection=True;";
            using SqlConnection connection = new(connectionString);
            string queryString = "SELECT Amount FROM Money WHERE Id = 2";
            SqlCommand command = new(queryString, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                decimal value = 0;
                int i = 0;
                while (reader.Read())
                {
                    if (!decimal.TryParse(reader[0].ToString(), out value))
                    {
                        MessageBox.Show("Ivvalid expense");
                    }
                }
                reader.Close();
                textBoxGoals.Text = Math.Round(value, 2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        private void UpdateExpenses()
        {
            string connectionString = "Server=localhost;Database=BudgetCalculator;Trusted_Connection=True;";
            string queryString = @"UPDATE Expense SET Amount = (CASE WHEN Id = 1 then @Housing
                                                                    WHEN Id = 2 then @Transportation
                                                                    WHEN Id = 3 then @Taxes
                                                                    WHEN Id = 4 then @Utilities
                                                                    WHEN Id = 5 then @Vices
                                                                    WHEN Id = 6 then @Food
                                                                    WHEN Id = 7 then @Insurance
                                                                    WHEN Id = 8 then @Entertainment
                                                                    WHEN Id = 9 then @Education
                                                                    WHEN Id = 10 then @Miscellaneous
                                                                    END)";
            using SqlConnection connection = new(connectionString);
            SqlCommand command = new(queryString, connection);
            command.Parameters.Add("@Housing", SqlDbType.Decimal).Value = IfEmpty(textBoxHousing.Text);
            command.Parameters.Add("@Transportation", SqlDbType.Decimal).Value = IfEmpty(textBoxTransportation.Text);
            command.Parameters.Add("@Taxes", SqlDbType.Decimal).Value = IfEmpty(textBoxTaxes.Text);
            command.Parameters.Add("@Utilities", SqlDbType.Decimal).Value = IfEmpty(textBoxUtilities.Text);
            command.Parameters.Add("@Vices", SqlDbType.Decimal).Value = IfEmpty(textBoxVices.Text);
            command.Parameters.Add("@Food", SqlDbType.Decimal).Value = IfEmpty(textBoxFood.Text);
            command.Parameters.Add("@Insurance", SqlDbType.Decimal).Value = IfEmpty(textBoxInsurance.Text);
            command.Parameters.Add("@Entertainment", SqlDbType.Decimal).Value = IfEmpty(textBoxEntertainment.Text);
            command.Parameters.Add("@Education", SqlDbType.Decimal).Value = IfEmpty(textBoxEducation.Text);
            command.Parameters.Add("@Miscellaneous", SqlDbType.Decimal).Value = IfEmpty(textBoxMiscellaneous.Text);
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
        }
        private void UpdateIncome()
        {
            string connectionString = "Server=localhost;Database=BudgetCalculator;Trusted_Connection=True;";
            string queryString = @"UPDATE Money SET Amount = @Amount WHERE Id = 1";
            using SqlConnection connection = new(connectionString);
            SqlCommand command = new(queryString, connection);
            command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = IfEmpty(textBoxIncome.Text);
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
        }
        private void UpdateGoals()
        {
            string connectionString = "Server=localhost;Database=BudgetCalculator;Trusted_Connection=True;";
            string queryString = @"UPDATE Money SET Amount = @Amount WHERE Id = 2";
            using SqlConnection connection = new(connectionString);
            SqlCommand command = new(queryString, connection);
            command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = IfEmpty(textBoxGoals.Text);
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
        }
        private void CalculateSavings()
        {
            labelSavingsAmount.Text = Math.Round(IncomeValue - ExpenseValue, 2).ToString();
        }
        private static decimal IfEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }
            else
            {
                return decimal.Parse(value);
            }
        }
        private void ButtonIncomeSet_Click(object sender, EventArgs e)
        {
            UpdateIncome();
            LoadIncome();
            CalculateSavings();
        }
        private void ButtonSetExpense_Click(object sender, EventArgs e)
        {
            UpdateExpenses();
            LoadExpenses();
            CalculateSavings();
        }
        private void ButtonSetGoals_Click(object sender, EventArgs e)
        {
            UpdateGoals();
            LoadGoals();
        }
    }
}