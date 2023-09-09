
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_01
{
    public class DAL
    {
        public void GetProductById(int id)
        {
            SqlConnection connection = new SqlConnection(
                "Data Source=EPUZTASW0537\\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True");

            private readonly string _connectionString = "Data Source=EPUZTASW0537\\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // Existing methods with updated exception handling

        public void CreateProduct(string name, double price, SqlConnection connection)
        {
            try
            {
                connection.Open();

                string commandText = $"INSERT INTO dbo.Product (ProductName, Price) VALUES ('{name}', {price});";
                SqlCommand sqlCommand = new SqlCommand(commandText, connection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DALException("An error occurred while creating a product.", ex);
            }



            try
            {
                connection.Open();

                string command = $"SELECT * FROM dbo.Product WHERE Id = {id}";
                SqlCommand sqlCommand = new SqlCommand(command, connection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    while (reader.Read())
                    {
                        object productId = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object price = reader.GetValue(2);

                        Console.WriteLine("{0} \t{1} \t{2}", productId, name, price);
                    }
                }
                else
                {
                    Console.WriteLine("No product found with the specified ID.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public void GetProductsByCategoryId(int categoryId)
        {
            SqlConnection connection = new SqlConnection(
                "Data Source=EPUZTASW0537\\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True");

            try
            {
                connection.Open();

                string sqlCommandText = $"SELECT * FROM dbo.Product WHERE CategoryId = {categoryId}";
                SqlCommand sqlCommand = new SqlCommand(sqlCommandText, connection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object price = reader.GetValue(2);
                        object category = reader.GetValue(3);

                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", id, name, price, category);
                    }
                }
                else
                {
                    Console.WriteLine("No products found with the specified category ID.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public void GetProductsByName(string productName)
        {
            SqlConnection connection = new SqlConnection(
                "Data Source=EPUZTASW0537\\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True");

            try
            {
                connection.Open();

                string sqlCommandText = $"SELECT * FROM dbo.Product WHERE ProductName LIKE '%{productName}%'";
                SqlCommand sqlCommand = new SqlCommand(sqlCommandText, connection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object price = reader.GetValue(2);

                        Console.WriteLine("{0}\t{1}\t{2}", id, name, price);
                    }
                }
                else
                {
                    Console.WriteLine("No products found with the specified name.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public void ReadByPriceGreaterThan(decimal minPrice)
        {
            SqlConnection connection = new SqlConnection(
                "Data Source=EPUZTASW0537\\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True");

            try
            {
                connection.Open();

                string command = $"SELECT * FROM dbo.Product WHERE Price > {minPrice}";
                SqlCommand sqlCommand = new SqlCommand(command, connection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object price = reader.GetValue(2);

                        Console.WriteLine("{0}\t{1}\t{2}", id, name, price);
                    }
                }
                else
                {
                    Console.WriteLine("No products found with a price greater than the specified amount.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public void CreateProduct(string name, decimal price)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void ReadAllProducts()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int id, string newName, decimal newPrice)
        {
            throw new NotImplementedException();
        }
    }
}

