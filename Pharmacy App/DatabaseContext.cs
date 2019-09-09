using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_App
{
    /// <summary>
    /// Context to access the database
    /// </summary>
    public class DatabaseContext
    {
        //Used to connect to the database
        private string connectionString;

        /// <summary>
        /// Initialises the connection string, input your specific username and password
        /// you set when setting up MySQL
        /// </summary>
        public DatabaseContext()
        {
            connectionString = @"server=localhost;database=PharmacyApp;userid=;password=;";
        }

        /// <summary>
        /// Gets every sale in the database
        /// </summary>
        /// <returns>A list of sales records</returns>
        public List<SalesRecord> GetAllSales()
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
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
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
        public SalesRecord GetSalesRecord(int salesID)
        {
            SalesRecord salesRecords = new SalesRecord();

            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlDataReader rdr = null;

            try
            {
                cnn.Open();
                string stm = "SELECT * FROM Sales WHERE SaleID = "+salesID;
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    salesRecords.SaleID = rdr.GetInt32(0);
                    salesRecords.Product = rdr.GetString(1);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if(rdr!=null)
                {
                    rdr.Close();
                }

                if(cnn!=null)
                {
                    cnn.Close();
                }
            }
            return salesRecords;
        }

    }
}
