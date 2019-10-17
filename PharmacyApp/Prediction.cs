using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp
{
    static class Prediction
    {
        
        //Used to connect to the database
        static private string ConnectionString = @"server=localhost;database=PharmacyApp;userid=root;password=Password;";

        /// <summary>
        /// This methods returns the percentage of the product 
        /// sold in the last week/month
        /// </summary>
        /// <param name="productID">The Product you want to predict sales for</param>
        /// <param name="reportType">The type of report generated week/month</param>
        /// <returns></returns>
        static public double? PredictProductSales(int productID, string reportType)
        {
            MySqlConnection cnn = new MySqlConnection(ConnectionString);
            MySqlConnection cnn2 = new MySqlConnection(ConnectionString);
            MySqlDataReader rdr = null;

            int totalSales = 0, productSales = 0;
            double? productPercentage = 0;

            try
            {
                cnn.Open();
                string stm = "SELECT Quantity FROM Sales WHERE DateSold BETWEEN CURDATE()-INTERVAL 1 " + reportType + " AND CURDATE()";
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
                        totalSales += rdr.GetInt32(0);
                    }
                }

                cnn.Close();
                cnn2.Open();

                stm = "SELECT Quantity FROM Sales WHERE ProductID = " + productID + " AND DateSold BETWEEN CURDATE()-INTERVAL 1 " + reportType + " AND CURDATE()";
                cmd = new MySqlCommand(stm, cnn2);
                rdr = cmd.ExecuteReader();

                if (!rdr.HasRows)
                {
                    throw new Exception("No sales records found!");
                }
                else
                {
                    while (rdr.Read())
                    {
                        productSales += rdr.GetInt32(0);
                    }
                }

                productPercentage = Math.Round((Convert.ToDouble(productSales) / Convert.ToDouble(totalSales)), 2);

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

                if (cnn2 != null)
                {
                    cnn2.Close();
                }
            }
            return productPercentage;
        }
    }
}
