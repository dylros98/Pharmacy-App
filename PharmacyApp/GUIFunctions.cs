using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    /// <summary>
    /// This class contains all of the methods used by the GUI to 
    /// add/edit SalesRecords, ProductRecords and SalesReports.
    /// </summary>
    class GUIFunctions
    {
        /// <summary>
        /// This method is responsible for adding the newest record in the database
        /// into the GUI table.
        /// </summary>
        /// <param name="table">A Table Layout Panel you want to add a new record to.</param>
        /// <param name="rowIndex">The row index where you want to add the new record.</param>
        static public void addNewRecord(TableLayoutPanel table, int rowIndex)
        {
            // Gets latest sale record from the database
            SalesRecord record = DatabaseContext.GetNewestSalesRecord();

            // Finds the corresponding Product Record for the SalesRecord
            ProductRecord pRecord = DatabaseContext.GetProductByProductID(record.ProductID);

            // Creates a new row in the table and updates the text in the cells
            table.Controls.Add(new Label() { Text = record.SaleID.ToString() }, 0, rowIndex);
            table.Controls.Add(new Label() { Text = pRecord.Name.ToString() }, 1, rowIndex);
            table.Controls.Add(new Label() { Text = record.DateSold.ToString() }, 2, rowIndex);
            table.Controls.Add(new Label() { Text = record.Quantity.ToString() }, 3, rowIndex);
            table.Controls.Add(new Label() { Text = "$" + (pRecord.Price * record.Quantity).ToString() }, 4, rowIndex);
        }

        /// <summary>
        /// This method is responsible for adding a SalesRecord into the GUI table.
        /// </summary>
        /// <param name="table">A Table Layout Panel you want to add a new record to.</param>
        /// <param name="rowIndex">The row index where you want to add the new record.</param>
        /// <param name="salesRecord">The SalesRecord you want to add to the table.</param>
        static public void addNewRecord(TableLayoutPanel table, int rowIndex, SalesRecord salesRecord)
        {
            // Finds the corresponding Product Record for the SalesRecord
            ProductRecord pRecord = DatabaseContext.GetProductByProductID(salesRecord.ProductID);

            // Creates a new row in the table and updates the text in the cells
            table.Controls.Add(new Label() { Text = salesRecord.SaleID.ToString() }, 0, rowIndex);
            table.Controls.Add(new Label() { Text = pRecord.Name.ToString() }, 1, rowIndex);
            table.Controls.Add(new Label() { Text = salesRecord.DateSold.ToString() }, 2, rowIndex);
            table.Controls.Add(new Label() { Text = salesRecord.Quantity.ToString() }, 3, rowIndex);
            table.Controls.Add(new Label() { Text = "$" + (pRecord.Price * salesRecord.Quantity).ToString() }, 4, rowIndex);
        }

        /// <summary>
        /// This method is responsible for adding the a new ProductRecord to the table.
        /// It does this by looking for the most recently added ProductRecord in the databse.
        /// </summary>
        /// <param name="table">A Table Layout Panel you want to add a new record to.</param>
        /// <param name="rowIndex">The row index where you want to add the new record.</param>
        static public void addNewProductRecord(TableLayoutPanel table, int rowIndex)
        {
            // Getting the new Product Record
            ProductRecord record = DatabaseContext.GetNewestProduct();

            // Creates a new row in the table and updates the text in the cells
            table.Controls.Add(new Label() { Text = record.ProductID.ToString() }, 0, rowIndex);
            table.Controls.Add(new Label() { Text = record.Name }, 1, rowIndex);
            table.Controls.Add(new Label() { Text = record.Description }, 2, rowIndex);
            table.Controls.Add(new Label() { Text = "$" + record.Price.ToString() }, 3, rowIndex);
            table.Controls.Add(new Label() { Text = record.Category }, 4, rowIndex);
        }

        /// <summary>
        /// This method is responsible for adding a given ProductRecord to the table.
        /// </summary>
        /// <param name="table">A Table Layout Panel you want to add a new record to.</param>
        /// <param name="rowIndex">The row index where you want to add the new record.</param>
        /// <param name="productRecord">The ProductRecod you want to add to the table.</param>
        static public void addNewProductRecord(TableLayoutPanel table, int rowIndex, ProductRecord productRecord)
        {
            // Creates a new row in the table and updates the text in the cells
            table.Controls.Add(new Label() { Text = productRecord.ProductID.ToString() }, 0, rowIndex);
            table.Controls.Add(new Label() { Text = productRecord.Name }, 1, rowIndex);
            table.Controls.Add(new Label() { Text = productRecord.Description }, 2, rowIndex);
            table.Controls.Add(new Label() { Text = "$" + productRecord.Price.ToString() }, 3, rowIndex);
            table.Controls.Add(new Label() { Text = productRecord.Category }, 4, rowIndex);
        }

        /// <summary>
        /// This method is responsible for changing the background color of a row.
        /// </summary>
        /// <param name="table">A table layout panel where you want to change the color of a row.</param>
        /// <param name="rowIndex">The row index where you want to add the new record.</param>
        /// <param name="backColor">The color you want to make the row.</param>
        static public void setRowBackground(TableLayoutPanel table, int rowIndex, Color backColor)
        {
            // Changing the background color of the labels in a row
            table.GetControlFromPosition(0, rowIndex).BackColor = backColor;
            table.GetControlFromPosition(1, rowIndex).BackColor = backColor;
            table.GetControlFromPosition(2, rowIndex).BackColor = backColor;
            table.GetControlFromPosition(3, rowIndex).BackColor = backColor;
            table.GetControlFromPosition(4, rowIndex).BackColor = backColor;
        }

        /// <summary>
        /// This method is responsible for editing a recod in the GUI
        /// </summary>
        /// <param name="table">A Table Layout Panel you want to add a new record to.</param>
        /// <param name="rowIndex">The row index where you want to add the new record.</param>
        /// <param name="salesRecord">The sales record that you are editting.</param>
        /// <param name="productRecord">The corresponding ProductRecord for the SalesRecord.</param>
        static public void editRecord(TableLayoutPanel table, int rowIndex, SalesRecord salesRecord, ProductRecord productRecord)
        {
            // Modifying the text within the labels for the SalesRecord
            table.GetControlFromPosition(1, rowIndex).Text = productRecord.Name;
            table.GetControlFromPosition(2, rowIndex).Text = salesRecord.DateSold.ToString();
            table.GetControlFromPosition(3, rowIndex).Text = salesRecord.Quantity.ToString();
            table.GetControlFromPosition(4, rowIndex).Text = "$" + (productRecord.Price * salesRecord.Quantity).ToString();
        }

        /// <summary>
        /// This method is responsible for adding a new ReportRecord to a table.
        /// </summary>
        /// <param name="table">A Table Layout Panel you want to add a new record to.</param>
        /// <param name="rowIndex">The row index where you want to add the new record.</param>
        /// <param name="reportRecord">The SalesReport record that you are adding to the table.</param>
        static public void addNewReportRecord(TableLayoutPanel table, int rowIndex, SalesReport reportRecord)
        {
            // Creates a new row in the table and updates the text in the cells
            table.Controls.Add(new Label() { Text = reportRecord.ProductID.ToString() }, 0, rowIndex);
            table.Controls.Add(new Label() { Text = reportRecord.Name.ToString() }, 1, rowIndex);
            table.Controls.Add(new Label() { Text = reportRecord.Quantity.ToString() }, 2, rowIndex);
            table.Controls.Add(new Label() { Text = reportRecord.Price.ToString() }, 3, rowIndex);
            table.Controls.Add(new Label() { Text = reportRecord.Total.ToString() }, 4, rowIndex);
        }
    }
}
