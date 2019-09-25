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
    public partial class Main : Form
    {

        private int rowIndex = 1;
        public Main()
        {
            InitializeComponent();
        }

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            SalesRecord newRecord;

            using (Add_EditSalesRecord addRecord = new Add_EditSalesRecord())
            {
                if(addRecord.ShowDialog() == DialogResult.OK)
                {
                    newRecord = DatabaseContext.GetSalesRecord(addRecord.ProductID);
                    addNewRecord(newRecord);
                }
            }
        }

        private void BtnWeeklyReport_Click(object sender, EventArgs e)
        {
            Report weeklyReport = new Report();
            weeklyReport.setTitleText("Weekly Sales Report");
            weeklyReport.Show();
        }

        private void BtnMonthlyReport_Click(object sender, EventArgs e)
        {
            Report monthlyReport = new Report();
            monthlyReport.setTitleText("Monthly Sales Report");
            monthlyReport.Show();
        }

        private void TlpDataRecords_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            //updateSales();

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
                l.BackColor = Color.White;
            }

            if (row != 0)
            {
                tlpDataRecords.GetControlFromPosition(0, row).BackColor = Color.LightBlue;
                tlpDataRecords.GetControlFromPosition(1, row).BackColor = Color.LightBlue;
                tlpDataRecords.GetControlFromPosition(2, row).BackColor = Color.LightBlue;
                tlpDataRecords.GetControlFromPosition(3, row).BackColor = Color.LightBlue;
                tlpDataRecords.GetControlFromPosition(4, row).BackColor = Color.LightBlue;
            }
        }

        private void TlpDataRecords_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        public void addNewRecord(SalesRecord record)
        {
            tlpDataRecords.Controls.Add(new Label() { Text = record.SaleID.ToString() }, 0, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.Product.ToString() }, 1, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.DateSold.ToString() }, 2, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.Quantity.ToString() }, 3, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.Price.ToString() }, 4, rowIndex);
           
            /*int rowIndex = 1;
            foreach (SalesRecord s in DatabaseContext.GetAllSales())
            {
                tlpDataRecords.Controls.Add(new Label() { Text = s.SaleID.ToString() }, 0, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.Product.ToString() }, 1, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.DateSold.ToString() }, 2, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.Quantity.ToString() }, 3, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.Price.ToString() }, 4, rowIndex);
                rowIndex++;
            }*/
        }
    }
}
