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
    public partial class Database : Form
    {

        private int rowIndex = 1;
        private int selectedRow = 0;

        public Database()
        {
            InitializeComponent();
        }

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            using (Add_EditSalesRecord addRecord = new Add_EditSalesRecord())
            {
                if (addRecord.ShowDialog() == DialogResult.OK)
                {
                    addNewRecord();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<SalesRecord> allSales = DatabaseContext.GetAllSales();
            foreach (SalesRecord s in allSales)
            {
                ProductRecord p = DatabaseContext.GetProductByProductID(s.ProductID);

                tlpDataRecords.Controls.Add(new Label() { Text = s.SaleID.ToString() }, 0, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = p.Name.ToString() }, 1, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.DateSold.ToString() }, 2, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.Quantity.ToString() }, 3, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = "$" + (p.Price * s.Quantity).ToString() }, 4, rowIndex);
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

        public void addNewRecord()
        {
            SalesRecord record = DatabaseContext.GetNewestSalesRecord();
            ProductRecord pRecord = DatabaseContext.GetProductByProductID(record.ProductID);

            tlpDataRecords.Controls.Add(new Label() { Text = record.SaleID.ToString() }, 0, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = pRecord.Name.ToString() }, 1, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.DateSold.ToString() }, 2, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.Quantity.ToString() }, 3, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = "$" + (pRecord.Price * record.Quantity).ToString() }, 4, rowIndex);
            rowIndex++;
        }

        private void BtnEditRecord_Click(object sender, EventArgs e)
        {
            if (selectedRow == 0)
            {
                MessageBox.Show("Please select a sales record to edit first.");
            }
            else
            {
                using (EditSalesRecord editRecord = new EditSalesRecord())
                {
                    SalesRecord saleData = DatabaseContext.GetSalesRecordWithSaleID(Int32.Parse(tlpDataRecords.GetControlFromPosition(0, selectedRow).Text));
                    editRecord.SaleRecord = saleData;

                    if (editRecord.ShowDialog() == DialogResult.OK)
                    {
                        saleData = DatabaseContext.GetSalesRecordWithSaleID(Int32.Parse(tlpDataRecords.GetControlFromPosition(0, selectedRow).Text));
                        ProductRecord pRecord = DatabaseContext.GetProductByProductID(saleData.ProductID);
                        tlpDataRecords.GetControlFromPosition(1, selectedRow).Text = pRecord.Name;
                        tlpDataRecords.GetControlFromPosition(2, selectedRow).Text = saleData.DateSold.ToString();
                        tlpDataRecords.GetControlFromPosition(3, selectedRow).Text = saleData.Quantity.ToString();
                        tlpDataRecords.GetControlFromPosition(4, selectedRow).Text = "$" + (pRecord.Price * saleData.Quantity).ToString();
                    }
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        private void addNewProduct_Click(object sender, EventArgs e)
        {
            using (AddNewProduct addNewProduct = new AddNewProduct())
            {
                addNewProduct.ShowDialog();
            }
        }
    }
}
