using System;
using System.Data;
using System.Data.SqlClient;

namespace Shop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To My Shop!");
            string connectionString = "Server=localhost;Database=Shop;Trusted_Connection=True;";
            string queryString = "SELECT c.Name, p.Name FROM Category c INNER JOIN Product p ON c.Id = p.CategoryId ORDER BY c.Name, p.Name";
            using SqlConnection connection = new(connectionString);
            SqlCommand command = new(queryString, connection);
            try
            {
                string categoryName = string.Empty;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (categoryName == reader[0].ToString())
                    {
                        Console.Write(", {0}", reader[1]);
                    }
                    else
                    {
                        Console.Write(Environment.NewLine + "{0} => {1}", reader[0], reader[1]);
                    }
                    categoryName = reader[0].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }
    }
}