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
        public Main()
        {
            InitializeComponent();
        }

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            Add_EditSalesRecord addRecord = new Add_EditSalesRecord();
            addRecord.Show();
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
            int rowIndex = 1;
            foreach(SalesRecord s in DatabaseContext.GetAllSales())
            {
                tlpDataRecords.Controls.Add(new Label() { Text = s.SaleID.ToString() }, 0, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.Product.ToString() }, 1, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.DateSold.ToString() }, 2, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.Quantity.ToString() }, 3, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.Price.ToString() }, 4, rowIndex);
                rowIndex++;
            }
        }
    }
}
