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
                    addNewProductRecord();
                }
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            List<ProductRecord> allProducts = DatabaseContext.GenerateAllProduct();
            foreach (ProductRecord p in allProducts)
            {

                tlpDataRecords.Controls.Add(new Label() { Text = p.ProductID.ToString() }, 0, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = p.Name }, 1, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = p.Description }, 2, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = "$" + p.Price.ToString() }, 3, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = p.Category }, 4, rowIndex);
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
                tlpDataRecords.GetControlFromPosition(0, row).BackColor = Color.FromArgb(134, 179, 209);
                tlpDataRecords.GetControlFromPosition(1, row).BackColor = Color.FromArgb(134, 179, 209);
                tlpDataRecords.GetControlFromPosition(2, row).BackColor = Color.FromArgb(134, 179, 209);
                tlpDataRecords.GetControlFromPosition(3, row).BackColor = Color.FromArgb(134, 179, 209);
                tlpDataRecords.GetControlFromPosition(4, row).BackColor = Color.FromArgb(134, 179, 209);
            }
            // Used for data retrieval for editing sales records
            selectedRow = row;
        }

        public void addNewProductRecord()
        {
            ProductRecord record = DatabaseContext.GetNewestProduct();

            tlpDataRecords.Controls.Add(new Label() { Text = record.ProductID.ToString() }, 0, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.Name }, 1, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.Description }, 2, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = "$" + record.Price.ToString() }, 3, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.Category }, 4, rowIndex);
            rowIndex++;
        }
    }
}

