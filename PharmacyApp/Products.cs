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
    public partial class Products : Form
    {
        private int rowIndex = 1;
        private int selectedRow = 0;

        public Products()
        {
            InitializeComponent();
        }

        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            using (AddNewProduct addNewProduct = new AddNewProduct())
            {
                if (addNewProduct.ShowDialog() == DialogResult.OK)
                {
                    GUIFunctions.addNewProductRecord(tlpDataRecords, rowIndex);
                    rowIndex++;
                }
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            List<ProductRecord> allProducts = ProductDatabase.GenerateAllProduct();
            foreach (ProductRecord p in allProducts)
            {
                GUIFunctions.addNewProductRecord(tlpDataRecords, rowIndex, p);
                rowIndex++;
            }

            foreach (Label l in tlpDataRecords.Controls)
            {
                l.MouseClick += new MouseEventHandler(selectRow);
            }
        }

        public void selectRow(object sender, MouseEventArgs e)
        {
            int row = tlpDataRecords.GetRow((Label)sender);

            foreach (Label l in tlpDataRecords.Controls)
            {
                l.BackColor = Color.FromArgb(95, 99, 102);
            }

            if (row != 0)
            {
                GUIFunctions.setRowBackground(tlpDataRecords, row, Color.FromArgb(134, 179, 209));
            }
            // Used for data retrieval for editing sales records
            selectedRow = row;
        }
        public void addNewProductRecord()
        {
            ProductRecord record = ProductDatabase.GetNewestProduct();

            tlpDataRecords.Controls.Add(new Label() { Text = record.ProductID.ToString() }, 0, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.Name }, 1, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.Description }, 2, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = "$" + record.Price.ToString() }, 3, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.Category }, 4, rowIndex);
            rowIndex++;
        }

        private void weeklyPredButton_Click(object sender, EventArgs e)
        {
            using (ItemSalesPrediction weeklySalesPredic = new ItemSalesPrediction("WEEK"))
            {
                weeklySalesPredic.ShowDialog();
            }
        }

        private void monthlyPredButton_Click(object sender, EventArgs e)
        {
            using (ItemSalesPrediction monthlySalesPredic = new ItemSalesPrediction("MONTH"))
            {
                monthlySalesPredic.ShowDialog();
            }
        }

        private void tlpDataRecords_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

