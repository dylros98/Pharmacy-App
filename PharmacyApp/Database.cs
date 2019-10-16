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
                    GUIFunctions.addNewRecord(tlpDataRecords, rowIndex);
                    rowIndex++;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<SalesRecord> allSales = DatabaseContext.GetAllSales();
            foreach (SalesRecord s in allSales)
            {
                GUIFunctions.addNewRecord(tlpDataRecords, rowIndex, s);
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
                        GUIFunctions.editRecord(tlpDataRecords, selectedRow, saleData, pRecord);
                    }
                }
            }
        }
    }
}
