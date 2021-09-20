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
        private decimal GoalsValue = 0;
        public BudgetCalculator()
        {
            InitializeComponent();
            LoadIncome();
            LoadGoals();
            LoadExpenses();
            CalculateSavings();
            CalculateGoal();
        }
        private static decimal IfEmptyOrNegative(string value)
        {
            if (string.IsNullOrEmpty(value) || decimal.Parse(value) < 0)
            {
                throw new EmptyOrNullOrNegativeException("Empty/Null/Negative value");
            }
            else
            {
                return decimal.Parse(value);
            }
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
                    if (!decimal.TryParse(reader[0].ToString(), out decimalArray[i]))
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
                while (reader.Read())
                {
                    if (!decimal.TryParse(reader[0].ToString(), out value))
                    {
                        MessageBox.Show("Ivvalid expense");
                    }
                }
                reader.Close();
                textBoxGoals.Text = Math.Round(value, 2).ToString();
                GoalsValue = value;
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
            try
            {
                command.Parameters.Add("@Housing", SqlDbType.Decimal).Value = IfEmptyOrNegative(textBoxHousing.Text);
                command.Parameters.Add("@Transportation", SqlDbType.Decimal).Value = IfEmptyOrNegative(textBoxTransportation.Text);
                command.Parameters.Add("@Taxes", SqlDbType.Decimal).Value = IfEmptyOrNegative(textBoxTaxes.Text);
                command.Parameters.Add("@Utilities", SqlDbType.Decimal).Value = IfEmptyOrNegative(textBoxUtilities.Text);
                command.Parameters.Add("@Vices", SqlDbType.Decimal).Value = IfEmptyOrNegative(textBoxVices.Text);
                command.Parameters.Add("@Food", SqlDbType.Decimal).Value = IfEmptyOrNegative(textBoxFood.Text);
                command.Parameters.Add("@Insurance", SqlDbType.Decimal).Value = IfEmptyOrNegative(textBoxInsurance.Text);
                command.Parameters.Add("@Entertainment", SqlDbType.Decimal).Value = IfEmptyOrNegative(textBoxEntertainment.Text);
                command.Parameters.Add("@Education", SqlDbType.Decimal).Value = IfEmptyOrNegative(textBoxEducation.Text);
                command.Parameters.Add("@Miscellaneous", SqlDbType.Decimal).Value = IfEmptyOrNegative(textBoxMiscellaneous.Text);
            }
            catch (EmptyOrNullOrNegativeException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            try
            {
                command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = IfEmptyOrNegative(textBoxIncome.Text);
            }
            catch (EmptyOrNullOrNegativeException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            try
            {
                command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = IfEmptyOrNegative(textBoxGoals.Text);
            }
            catch (EmptyOrNullOrNegativeException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void CalculateGoal()
        {
            decimal monthly = (IncomeValue - ExpenseValue) / 12;
            labelSavingsCalculation.Text = $"You are now saving {Math.Round((IncomeValue - ExpenseValue), 2)} per year" +
                $"{Environment.NewLine}or {Math.Round(monthly, 2)} per month." +
                $"{Environment.NewLine}You will reach your goal after {Math.Ceiling(GoalsValue / monthly)} months";
        }
        private void CalculateAndSetBudgetPerExpense(Label label, decimal amount, string expenseType, int avarageSpent)
        {
            int percent = (int)Math.Round((amount / IncomeValue) * 100);
            if (percent > avarageSpent)
            {
                label.ForeColor = Color.Red;
            }
            else
            {
                label.ForeColor = Color.Green;
            }
            label.Text = $"You spent {amount} for {expenseType} each year which is {percent}% of the budget.";
            label.Text += $"{Environment.NewLine}Avarage spent amount is {avarageSpent}% per year.";
        }
        private void ButtonSetIncome_Click(object sender, EventArgs e)
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
            CalculateGoal();
        }
        private void ButtonCalculateBudget_Click(object sender, EventArgs e)
        {
            try
            {
                CalculateAndSetBudgetPerExpense(labelHousingBudget, IfEmptyOrNegative(textBoxHousing.Text), "Housing", 23);
                CalculateAndSetBudgetPerExpense(labelTransportationBudget, IfEmptyOrNegative(textBoxTransportation.Text), "Transportation", 13);
                CalculateAndSetBudgetPerExpense(labelTaxesBudget, IfEmptyOrNegative(textBoxTaxes.Text), "Taxes", 12);
                CalculateAndSetBudgetPerExpense(labelUtilitiesBudget, IfEmptyOrNegative(textBoxUtilities.Text), "Utilities", 11);
                CalculateAndSetBudgetPerExpense(labelVicesBudget, IfEmptyOrNegative(textBoxVices.Text), "Vices", 7);
                CalculateAndSetBudgetPerExpense(labelFoodBudget, IfEmptyOrNegative(textBoxFood.Text), "Food", 14);
                CalculateAndSetBudgetPerExpense(labelInsuranceBudget, IfEmptyOrNegative(textBoxInsurance.Text), "Insurance", 9);
                CalculateAndSetBudgetPerExpense(labelEntertainmentBudget, IfEmptyOrNegative(textBoxEntertainment.Text), "Entertainment", 4);
                CalculateAndSetBudgetPerExpense(labelEducationBudget, IfEmptyOrNegative(textBoxEducation.Text), "Education", 4);
                CalculateAndSetBudgetPerExpense(labelMiscellaneousBudget, IfEmptyOrNegative(textBoxMiscellaneous.Text), "Miscellaneous", 3);
            }
            catch (EmptyOrNullOrNegativeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ButtonCalculateSavings_Click(object sender, EventArgs e)
        {
            CalculateGoal();
        }
    }
}