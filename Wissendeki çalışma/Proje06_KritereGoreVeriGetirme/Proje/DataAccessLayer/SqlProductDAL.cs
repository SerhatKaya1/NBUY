using System.Data.SqlClient;
using Proje.DataAccessLayer.Entities;
namespace Proje.DataAccessLayer
{
    public class SqlProductDAL : IProductDAL
    {
        private SqlConnection GetSqlConnection()
        {
            string connectionString = @"Server=DESKTOP-OFVK2FD\SQLEXPRESS; Database=Northwind; User=sa; Pwd=123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
        public void Create(Product product)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetAll() //Tüm productları bana getir dedik.
        {
            List<Product> products = new List<Product>();
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "SELECT ProductId, ProductName, UnitPrice, UnitsInStock FROM Products";
                    SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        products.Add(new Product()
                        {
                            Id = int.Parse(sqlDataReader[0].ToString()),
                            Name = sqlDataReader[1].ToString(),
                            Price = decimal.Parse(sqlDataReader[2].ToString()),
                            Stock = int.Parse(sqlDataReader[3].ToString())
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
        }
        public Product GetById(int id)
        {
            Product product = null;
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = $"SELECT ProductId, ProductName, UnitPrice, UnitsInStock FROM Products WHERE ProductId={id}";
                    SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Read();
                        product = new Product()
                        {
                            Id = int.Parse(sqlDataReader[0].ToString()),
                            Name = sqlDataReader[1].ToString(),
                            Price = decimal.Parse(sqlDataReader[2].ToString()),
                            Stock = int.Parse(sqlDataReader[3].ToString())
                        };
                    }
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return product;
        }
        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        //ProductId, ProductName, UnitPric, UnitInStock'u dan verileri ekrana getir diyoruz.

        public List<Product> GetProductsByCategoryId(int id)
        {
            List<Product> products = new List<Product>();
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = $"SELECT ProductId, ProductName, UnitPrice, UnitsInStock FROM Products WHERE CategoryId={id}";
                    SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read()) //Her birisini teker teker oku diyoruz.
                    {
                        products.Add(new Product() //Burada ise koleksiyonuma ekleme işlemi yapıyorum.
                        {
                            Id = int.Parse(sqlDataReader[0].ToString()), //int dönüştürerek şu index değerini bana tanımla diyoruz.
                            Name = sqlDataReader[1].ToString(), //ToString mantığını araştır .Emin değilim.
                            Price = decimal.Parse(sqlDataReader[2].ToString()), //decimal dönüşüm yaptık.
                            Stock = int.Parse(sqlDataReader[3].ToString()) //parse ile int tipinde bir dönüşüm yaptık .
                        });
                    }
                    sqlDataReader.Close(); //ekrana getirme işlemi bitince bağlantımızı kesiyoruz.
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir sorun oluştu!"); //Bğlantıda bir sorun varsa hata oluştu yazsın.
                }
                finally
                {
                    connection.Close(); //yoksa bitir.
                }
            }
            return products; //products içerisinde bir döngüde olsun diyoruz .
        }

        /*
         Bu bölümdede SELECT İLE SQL'de verilerimi görüntülemek için değerler yazdık.
        Try-Case ile kontrollerimizi yapıyoruz.
         */
        public List<Product> GetProductsByCategory(string categoryName) 
        {
            List<Product> products = new List<Product>(); //Koleksiyonumuza verilerimi aktarıyoruz.
            using (var connection = GetSqlConnection())  //Sql bağlantımı açıyorum . Yukarıda ilk başta static tanımladıysak tekrar tekrar yazmamıza gerek yok.
            {
                try
                {
                    connection.Open();
                    string queryString = $"SELECT P.ProductID,P.ProductName,P.UnitPrice,P.UnitsInStock FROM Products P INNER JOIN Categories C ON P.CategoryID=C.CategoryID WHERE C.CategoryName='{categoryName}'";
                    SqlCommand sqlCommand = new SqlCommand(queryString, connection); //Bağlanması gereken sql veri tabanımı bulacak ve sorgumu yapacak.
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(); //komutu çalıştır ve değerleri oku diyoruz.
                    while (sqlDataReader.Read()) //Döngü içinde teker teker okuyor.
                    {
                        products.Add(new Product() //Koleksiyonumuza değer ekleme işlemi yapıyoruz.
                        {
                            Id = int.Parse(sqlDataReader[0].ToString()), //Yukarıdakiler ile yapılan işlemler aynı işleyişe sahip.
                            Name = sqlDataReader[1].ToString(),
                            Price = decimal.Parse(sqlDataReader[2].ToString()),
                            Stock = int.Parse(sqlDataReader[3].ToString())
                        });
                    }
                    sqlDataReader.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir sorun oluştu!"); //bağlantı sağlanmazsa hata mesajı verir.
                }
                finally
                {
                    connection.Close(); //Burada veritabanı bağlantısısını kapadık.
                }
            }
            return products; //products içerisinde bir döngüde al diyoruz.
        }

    }
}