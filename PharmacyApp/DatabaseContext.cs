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
                if (!rdr.Read())
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
                            Product = rdr.GetString(1),
                            DateSold = rdr.GetDateTime(2),
                            Category = rdr.GetString(3)
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
        /// Gets a specific sales record using the SaleID
        /// </summary>
        /// <param name="salesID">ID of the specific sales record</param>
        /// <returns>The sales record</returns>
        static public SalesRecord GetSalesRecord(int salesID)
        {
            SalesRecord salesRecords = new SalesRecord();

            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlDataReader rdr = null;

            try
            {
                cnn.Open();
                string stm = "SELECT * FROM Sales WHERE SaleID = " + salesID;
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                rdr = cmd.ExecuteReader();

                if (!rdr.Read())
                {
                    throw new Exception("No sales record found for SaleID " + salesID);
                }
                else
                {
                    while (rdr.Read())
                    {
                        salesRecords.SaleID = rdr.GetInt32(0);
                        salesRecords.Product = rdr.GetString(1);
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
        /// Adds a new sales record to the database
        /// </summary>
        /// <param name="prod">Product name</param>
        /// <param name="cat">Product category</param>
        /// <param name="quan">Quantity of item sold</param>
        /// <param name="price">Price of product sold</param>
        /// <param name="desc">Product description</param>
        /// <returns></returns>
        static public void NewSalesEntry(string prod, string cat, int quan, double price, string desc)
        {
            // New connection object
            MySqlConnection cnn = new MySqlConnection(connectionString);

            try
            {
                // Opens database connection
                // Creates and executes query string
                cnn.Open();
                string stm = "INSERT INTO Sales (Product, DateSold, Category, Quantity, Price, Description) VALUES ('" + prod + "', CURRENT_DATE(), '" + cat + "', " + quan + ", " + price + ", '" + desc + ");";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
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

    }
}
