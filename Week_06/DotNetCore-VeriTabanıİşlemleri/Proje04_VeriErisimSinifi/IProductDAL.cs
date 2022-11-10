
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Proje04_VeriErisimSinifi
{
    public interface IProductDAL
    {
        private SqlConnection GetSqlConnection()
    {
        string connectionString = @"Server=DESKTOP-OFVK2FD\SQLEXPRESS; Database=Northwind; User=sa; Pwd=123";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        return sqlConnection;
    }
        void CreateProduct(Product product);    // C-reate
        List<Product> GetAllProducts();         // R-ead
        Product GetByIdProduct(int id); 
        void UpdateProduct(Product product);    // U-pdate
        void DeleteProduct(int id);             // D-elete
        List<Product> GetAllProductsByCategories(string categoryName);
    }
    public class SqliteProductDAL : IProductDAL
    {
        private SqliteConnection GetSqliteConnection{
            string connectionString="Data Source=Northwind.db";
            SqliteConnection sqliteConnection = new SqliteConnection(connectionString);
             }

        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
             List<Product> products = new List<Product>();
        using (var connection = GetSqliteConnection())
        {
            try
            {
                connection.Open();
                string queryString = "SELECT ProductId, ProductName, UnitPrice, UnitsInStock FROM Products";
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqliteDataReader.Read())
                {
                    products.Add(new Product(){
                        Id=int.Parse(SqliteDataReader)["ProductId"].ToString()),
                        Name=SqliteDataReader["ProductName"].ToString()),
                        Stock=int.Parse(SqliteDataReader["UnitPrice"].ToString))
                    });
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Bir sorun oluştu!");
            }
            finally
            {
                connection.Close();
            }
        }

        return products;
            throw new NotImplementedException();
        }

        public List<Product> GetAllProductsByCategories(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Product GetByIdProduct(int id)
        {
            List<Product> products = new List<Product>();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
   
}