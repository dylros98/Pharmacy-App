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
    }
}
