using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp
{
    /// <summary>
    /// Context to access the database
    /// </summary>
    static public class DatabaseContext
    {
        //Used to connect to the database
        static private string connectionString = @"server=localhost;database=PharmacyApp;userid=root;password=Password;";

        /// <summary>
        /// Gets every sale in the database
        /// </summary>
        /// <returns>A list of sales records</returns>
        static public List<SalesRecord> GetAllSales()
        {
            //New connection object
            MySqlConnection cnn = new MySqlConnection(connectionString);

            //Reads the result of the database query
            MySqlDataReader rdr = null;

            List<SalesRecord> salesRecords = new List<SalesRecord>();

            try
            {
                //Opens database connection, input query string
                //and use MySQL command to executre it with the connection
                cnn.Open();
                string stm = "SELECT * FROM Sales";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                rdr = cmd.ExecuteReader();

                //Checks if the query returned nothing
                if (!rdr.HasRows)
                {
                    throw new Exception("No sales records found");
                }
                else
                {
                    //Gets every result from the query
                    while (rdr.Read())
                    {
                        //Reader must get the specific type of the result
                        //for example, the SaleID is an Int32
                        //and since it's the first column, access it with index 0 and so on for
                        //other columns
                        SalesRecord salesRecord = new SalesRecord()
                        {
                            SaleID = rdr.GetInt32(0),
                            ProductID = rdr.GetInt32(1),
                            DateSold = rdr.GetDateTime(2),
                            Quantity = rdr.GetInt32(3)
                        };
                        salesRecords.Add(salesRecord);
                    }
                }
            }
            catch (Exception ex)
            {
                //If there's a problem with the query, return null
                //In form class, check if a database function returns null
                //and act accordingly if true
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                //Close the reader and connection
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            return salesRecords;
        }

        /// <summary>
        /// Gets a list of sales records that contain a specific product ID
        /// </summary>
        /// <param name="salesID">ID of the specific product</param>
        /// <returns>The sales record</returns>
        static public List<SalesRecord> GetSalesRecordsUsingProductID(int productID)
        {
            List<SalesRecord> salesRecords = new List<SalesRecord>();

            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlDataReader rdr = null;

            try
            {
                cnn.Open();
                string stm = "SELECT * FROM Sales WHERE ProductID = " + productID;
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                rdr = cmd.ExecuteReader();

                if (!rdr.HasRows)
                {
                    throw new Exception("No sales record found that contains product ID " + productID);
                }
                else
                {
                    while (rdr.Read())
                    {
                        salesRecords.Add(new SalesRecord()
                        {
                            SaleID = rdr.GetInt32(0),
                            ProductID = rdr.GetInt32(1),
                            DateSold = rdr.GetDateTime(2),
                            Quantity = rdr.GetInt32(3)
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
            return salesRecords;
        }

        /// <summary>
        /// Gets a list of sales records that contain a specific product ID
        /// </summary>
        /// <param name="salesID">ID of the specific product</param>
        /// <returns>The sales record</returns>
        static public SalesRecord GetSalesRecordWithSaleID(int salesID)
        {
            SalesRecord salesRecord = new SalesRecord();

            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlDataReader rdr = null;

            try
            {
                cnn.Open();
                string stm = "SELECT * FROM Sales WHERE SaleID = " + salesID;
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                rdr = cmd.ExecuteReader();

                if (!rdr.HasRows)
                {
                    throw new Exception("No sales record found that contains sale ID " + salesID);
                }
                else
                {
                    while (rdr.Read())
                    {

                        salesRecord.SaleID = rdr.GetInt32(0);
                        salesRecord.ProductID = rdr.GetInt32(1);
                        salesRecord.DateSold = rdr.GetDateTime(2);
                        salesRecord.Quantity = rdr.GetInt32(3);
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
            return salesRecord;
        }

        /// <summary>
        /// Gets the most recently added sales record
        /// </summary>
        /// <returns>The sales record</returns>
        static public SalesRecord GetNewestSalesRecord()
        {
            SalesRecord salesRecord = new SalesRecord();

            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlDataReader rdr = null;

            try
            {
                cnn.Open();
                string stm = "SELECT * FROM Sales WHERE SaleID = (SELECT MAX(SaleID) FROM Sales)";
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
                        salesRecord.SaleID = rdr.GetInt32(0);
                        salesRecord.ProductID = rdr.GetInt32(1);
                        salesRecord.DateSold = rdr.GetDateTime(2);
                        salesRecord.Quantity = rdr.GetInt32(3);
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
            return salesRecord;
        }

       /// <summary>
       /// Gets a product with the specified product ID
       /// </summary>
       /// <param name="productID">The ID of the specified product</param>
       /// <returns>The specified product</returns>
        static public ProductRecord GetProductByProductID(int productID)
        {
            ProductRecord productRecord = new ProductRecord();

            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlDataReader rdr = null;

            try
            {
                cnn.Open();
                string stm = "SELECT * FROM Products WHERE ProductID = "+productID;
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                rdr = cmd.ExecuteReader();

                if (!rdr.HasRows)
                {
                    throw new Exception("No product found for product ID "+productID);
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
        /// Adds a new sales record to the database
        /// </summary>
        /// <param name="prodId">Product ID</param>
        /// <param name="quan">Quantity purchased</param>
        /// <returns></returns>
        static public SalesRecord NewSalesEntry(int prodId, int quan)
        {
            // New connection object
            MySqlConnection cnn = new MySqlConnection(connectionString);
            SalesRecord salesRecord = new SalesRecord();
            try
            {
                // Opens database connection
                cnn.Open();

                // Add sale to Sales table
                string stm = "INSERT INTO Sales (ProductID, DateSold, Quantity) VALUES (" + prodId + ", CURRENT_DATE(), " + quan + ");";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                cmd.ExecuteNonQuery();

                salesRecord = GetNewestSalesRecord();
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
            return salesRecord;
        }

        static public void EditSalesRecord(int saleId, int prodId, int quan, string dateTime)
        {
            MySqlConnection cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();

                // Date needs to be parsed manually to update in database
                // Note: this was done fast and messy. I'll try to clean it up next sprint.
                string[] date = dateTime.Split('-');
                string[] months = {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
                int monthNum = 0;

                for (int i = 0; i < 12; i++)
                {
                    if (months[i] == date[1])
                        monthNum = i + 1;
                }
                string monthStr = monthNum.ToString();

                if (monthStr.Length == 1)
                    monthStr = "0" + monthStr;

                if (date[0].Length == 1)
                    date[0] = "0" + date[0];

                string parsedDate = "20" + date[2] + monthStr + date[0];
                Console.WriteLine(parsedDate);
                
                string stm = "UPDATE Sales SET ProductID = " + prodId + ", DateSold = " + parsedDate + ", Quantity = " + quan + " WHERE SaleID = " + saleId + ";";
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
                    cnn.Close();
            }
        }

        static public int[] GenerateProductIDs()
        {
            List<ProductRecord> check = GenerateAllProduct();
            int[] productList = new int[check.Count()];

            MySqlConnection cnn = new MySqlConnection(connectionString);
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

        static public List<ProductRecord> GenerateAllProduct()
        {
            List<ProductRecord> productList = new List<ProductRecord>();

            MySqlConnection cnn = new MySqlConnection(connectionString);
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

        static public int GenerateSalesAmount(int ID, bool monthly)
        {
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlDataReader rdr = null;
            int value = 0;

            try
            {
                cnn.Open();

                    string stm = "";
                    if (monthly)
                    {
                      stm = "SELECT SUM(Quantity) FROM Sales WHERE ProductID = " + ID + " AND DateSold BETWEEN CURDATE()-INTERVAL 1 MONTH AND CURDATE()";
                    }
                    else {
                      stm = "SELECT SUM(Quantity) FROM Sales WHERE ProductID = " + ID + " AND DateSold BETWEEN CURDATE()-INTERVAL 1 WEEK AND CURDATE()";
                    }
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
                            value = rdr.GetInt32(0);
                        }
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
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

            return value;

        }

        /// <summary>
        /// Adds a new sales record to the database
        /// </summary>
        /// <param name="prodId">Product ID</param>
        /// <param name="quan">Quantity purchased</param>
        /// <returns></returns>
        static public void AddNewProduct(ProductRecord newProduct)
        {
            // New connection object
            MySqlConnection cnn = new MySqlConnection(connectionString);

            try
            {
                // Opens database connection
                cnn.Open();

                // Add sale to Sales table
                string stm = "INSERT INTO Products (Name, Description, Price, Category) VALUES ('" + newProduct.Name + "', '"+newProduct.Description+"', "+newProduct.Price+ ", '"+newProduct.Category+"');";
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
        /// Gets the most recently added sales record
        /// </summary>
        /// <returns>The sales record</returns>
        static public ProductRecord GetNewestProduct()
        {
            ProductRecord productRecord = new ProductRecord();

            MySqlConnection cnn = new MySqlConnection(connectionString);
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
