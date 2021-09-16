using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BudgetCalculator
{
    public partial class Income : Form
    {
        public Income(string currency)
        {
            InitializeComponent();
            ChangeCurrency(currency);
            LoadAmounts();
        }

        private void ChangeCurrency(string currency)
        {
            foreach (Control c in Controls)
            {
                if (c.Name.ToString().Contains("labelCurrency"))
                {
                    c.Text = currency;
                }
            }
        }

        private static decimal ZeroIfEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(value);
            }
        }

        private void UpdateAmounts()
        {
            string connectionString = "Server=localhost;Database=BudgetCalculator;Trusted_Connection=True;";
            string queryString = @"UPDATE INCOME SET Amount = (CASE WHEN Id = 1 then @JanuaryAmount
                                                                    WHEN Id = 2 then @FebruaryAmount
                                                                    WHEN Id = 3 then @MarchAmount
                                                                    WHEN Id = 4 then @AprilAmount
                                                                    WHEN Id = 5 then @MayAmount
                                                                    WHEN Id = 6 then @JuneAmount
                                                                    WHEN Id = 7 then @JulyAmount
                                                                    WHEN Id = 8 then @AugustAmount
                                                                    WHEN Id = 9 then @SeptemberAmount
                                                                    WHEN Id = 10 then @OctoberAmount
                                                                    WHEN Id = 11 then @NovemberAmount
                                                                    WHEN Id = 12 then @DecemberAmount
                                                                    END)";

            using SqlConnection connection = new(connectionString);
            SqlCommand command = new(queryString, connection);
            connection.Open();
            command.Parameters.Add("@JanuaryAmount", SqlDbType.Decimal).Value = ZeroIfEmpty(textBoxJanuary.Text);
            command.Parameters.Add("@FebruaryAmount", SqlDbType.Decimal).Value = ZeroIfEmpty(textBoxFebruary.Text);
            command.Parameters.Add("@MarchAmount", SqlDbType.Decimal).Value = ZeroIfEmpty(textBoxMarch.Text);
            command.Parameters.Add("@AprilAmount", SqlDbType.Decimal).Value = ZeroIfEmpty(textBoxApril.Text);
            command.Parameters.Add("@MayAmount", SqlDbType.Decimal).Value = ZeroIfEmpty(textBoxMay.Text);
            command.Parameters.Add("@JuneAmount", SqlDbType.Decimal).Value = ZeroIfEmpty(textBoxJune.Text);
            command.Parameters.Add("@JulyAmount", SqlDbType.Decimal).Value = ZeroIfEmpty(textBoxJuly.Text);
            command.Parameters.Add("@AugustAmount", SqlDbType.Decimal).Value = ZeroIfEmpty(textBoxAugust.Text);
            command.Parameters.Add("@SeptemberAmount", SqlDbType.Decimal).Value = ZeroIfEmpty(textBoxSeptember.Text);
            command.Parameters.Add("@OctoberAmount", SqlDbType.Decimal).Value = ZeroIfEmpty(textBoxOctober.Text);
            command.Parameters.Add("@NovemberAmount", SqlDbType.Decimal).Value = ZeroIfEmpty(textBoxNovember.Text);
            command.Parameters.Add("@DecemberAmount", SqlDbType.Decimal).Value = ZeroIfEmpty(textBoxDecember.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            this.Close();
        }
        private void LoadAmounts()
        {
            string connectionString = "Server=localhost;Database=BudgetCalculator;Trusted_Connection=True;";
            string queryString = "SELECT Id, Amount FROM Income";
            using SqlConnection connection = new(connectionString);
            SqlCommand command = new(queryString, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    switch (reader[0])
                    {
                        case 1:
                            textBoxJanuary.Text = reader[1].ToString();
                            break;
                        case 2:
                            textBoxFebruary.Text = reader[1].ToString();
                            break;
                        case 3:
                            textBoxMarch.Text = reader[1].ToString();
                            break;
                        case 4:
                            textBoxApril.Text = reader[1].ToString();
                            break;
                        case 5:
                            textBoxMay.Text = reader[1].ToString();
                            break;
                        case 6:
                            textBoxJune.Text = reader[1].ToString();
                            break;
                        case 7:
                            textBoxJuly.Text = reader[1].ToString();
                            break;
                        case 8:
                            textBoxAugust.Text = reader[1].ToString();
                            break;
                        case 9:
                            textBoxSeptember.Text = reader[1].ToString();
                            break;
                        case 10:
                            textBoxOctober.Text = reader[1].ToString();
                            break;
                        case 11:
                            textBoxNovember.Text = reader[1].ToString();
                            break;
                        case 12:
                            textBoxDecember.Text = reader[1].ToString();
                            break;
                        default:
                            break;

                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void ButtonSet_Click(object sender, EventArgs e)
        {
            UpdateAmounts();
            this.Close();
        }
    }
}
