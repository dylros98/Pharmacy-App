using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp
{
    static class ProductDatabase
    {

        //Used to connect to the database
        static private string ConnectionString = @"server=localhost;database=PharmacyApp;userid=root;password=Password;";

        /// <summary>
        /// Gets a product with the specified product ID
        /// </summary>
        /// <param name="productID">The ID of the specified product</param>
        /// <returns>The specified product</returns>
        static public ProductRecord GetProductByProductID(int productID)
        {
            ProductRecord productRecord = new ProductRecord();

            MySqlConnection cnn = new MySqlConnection(ConnectionString);
            MySqlDataReader rdr = null;

            try
            {
                cnn.Open();
                string stm = "SELECT * FROM Products WHERE ProductID = " + productID;
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                rdr = cmd.ExecuteReader();

                if (!rdr.HasRows)
                {
                    throw new Exception("No product found for product ID " + productID);
                }
                else
                {
                    while (rdr.Read())
                    {
                        productRecord.ProductID = rdr.GetInt32(0);
                        productRecord.Name = rdr.GetString(1);
                        productRecord.Description = rdr.GetString(2);
                        productRecord.Price = rdr.GetDouble(3);
                        productRecord.Category = rdr.GetString(4);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            return productRecord;
        }

        /// <summary>
        /// Returns a list of every productID in the database
        /// </summary>
        /// <returns>A list of all products in the database</returns>
        static public int[] GenerateProductIDs()
        {
            List<ProductRecord> check = GenerateAllProduct();
            int[] productList = new int[check.Count()];

            MySqlConnection cnn = new MySqlConnection(ConnectionString);
            MySqlDataReader rdr = null;

            try
            {
                cnn.Open();

                string stm = "SELECT ProductId FROM Products";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                rdr = cmd.ExecuteReader();

                if (!rdr.HasRows)
                {
                    throw new Exception("No sales records found!");
                }
                else
                {
                    int i = 0;
                    while (rdr.Read())
                    {
                        productList[i] = rdr.GetInt32(0);
                        i++;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (cnn != null)
                {
                    cnn.Close();
                }
            }

            return productList;

        }

        /// <summary>
        /// Returns a list of all the ProductRecords
        /// </summary>
        /// <returns>A list of all ProductRecords</returns>
        static public List<ProductRecord> GenerateAllProduct()
        {
            List<ProductRecord> productList = new List<ProductRecord>();

            MySqlConnection cnn = new MySqlConnection(ConnectionString);
            MySqlDataReader rdr = null;

            try
            {
                cnn.Open();

                string stm = "SELECT * FROM Products";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                rdr = cmd.ExecuteReader();

                if (!rdr.HasRows)
                {
                    throw new Exception("No sales records found!");
                }
                else
                {
                    while (rdr.Read())
                    {
                        productList.Add(new ProductRecord()
                        {
                            ProductID = rdr.GetInt32(0),
                            Name = rdr.GetString(1),
                            Description = rdr.GetString(2),
                            Price = rdr.GetDouble(3),
                            Category = rdr.GetString(4)
                        });
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (cnn != null)
                {
                    cnn.Close();
                }
            }

            return productList;

        }

        
        /// <summary>
        /// Adds a new ProductRecord to the database
        /// </summary>
        /// <param name="newProduct">The new ProductRecord to add</param>
        static public void AddNewProduct(ProductRecord newProduct)
        {
            // New connection object
            MySqlConnection cnn = new MySqlConnection(ConnectionString);

            try
            {
                // Opens database connection
                cnn.Open();

                // Add sale to Sales table
                string stm = "INSERT INTO Products (Name, Description, Price, Category) VALUES ('" + newProduct.Name + "', '" + newProduct.Description + "', " + newProduct.Price + ", '" + newProduct.Category + "');";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
        }

        /// <summary>
        /// Returns the newest ProductRecord in the database
        /// </summary>
        /// <returns>The newest product record</returns>
        static public ProductRecord GetNewestProduct()
        {
            ProductRecord productRecord = new ProductRecord();

            MySqlConnection cnn = new MySqlConnection(ConnectionString);
            MySqlDataReader rdr = null;

            try
            {
                cnn.Open();
                string stm = "SELECT * FROM Products WHERE ProductID = (SELECT MAX(ProductID) FROM Products)";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                rdr = cmd.ExecuteReader();

                if (!rdr.HasRows)
                {
                    throw new Exception("No sales records found!");
                }
                else
                {
                    while (rdr.Read())
                    {
                        productRecord.ProductID = rdr.GetInt32(0);
                        productRecord.Name = rdr.GetString(1);
                        productRecord.Description = rdr.GetString(2);
                        productRecord.Price = rdr.GetDouble(3);
                        productRecord.Category = rdr.GetString(4);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            return productRecord;
        }
    }
}
