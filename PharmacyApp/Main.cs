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
        private SalesReportGenerator List;
        public Main()
        {
            List = new SalesReportGenerator();
            InitializeComponent();
        }

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            using (Add_EditSalesRecord addRecord = new Add_EditSalesRecord())
            {
                if(addRecord.ShowDialog() == DialogResult.OK)
                {
                    addNewRecord();
                }
            }
        }

        private void BtnWeeklyReport_Click(object sender, EventArgs e)
        {
            Report weeklyReport = new Report(List.ReportList());
            weeklyReport.setTitleText("Weekly Sales Report");
            weeklyReport.Show();
        }

        private void BtnMonthlyReport_Click(object sender, EventArgs e)
        {
            Report monthlyReport = new Report(List.ReportList());
            monthlyReport.setTitleText("Monthly Sales Report");
            monthlyReport.Show();
        }

        private void TlpDataRecords_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            foreach (SalesRecord s in DatabaseContext.GetAllSales())
            {
                ProductRecord p = DatabaseContext.GetProductByProductID(s.ProductID);

                tlpDataRecords.Controls.Add(new Label() { Text = s.SaleID.ToString() }, 0, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = p.Name.ToString() }, 1, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.DateSold.ToString() }, 2, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.Quantity.ToString() }, 3, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = "$"+(p.Price*s.Quantity).ToString() }, 4, rowIndex);
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

        public void addNewRecord()
        {
            SalesRecord record = DatabaseContext.GetNewestSalesRecord();
            ProductRecord pRecord = DatabaseContext.GetProductByProductID(record.ProductID);

            tlpDataRecords.Controls.Add(new Label() { Text = record.SaleID.ToString() }, 0, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = pRecord.Name.ToString() }, 1, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.DateSold.ToString() }, 2, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = record.Quantity.ToString() }, 3, rowIndex);
            tlpDataRecords.Controls.Add(new Label() { Text = "$"+(pRecord.Price*record.Quantity).ToString() }, 4, rowIndex);
            rowIndex++;           
        }

        private void BtnEditRecord_Click(object sender, EventArgs e)
        {
            using (EditSalesRecord editRecord = new EditSalesRecord())
            {
                if (editRecord.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
