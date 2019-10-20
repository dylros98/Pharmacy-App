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
    public partial class DateSelection : Form
    {
        private SalesReportGenerator List;

        public DateSelection()
        {
            List = new SalesReportGenerator();
            InitializeComponent();
        }

        private void BtnWeeklyReport_Click(object sender, EventArgs e)
        {
            
            Report weeklyReport = new Report(List.ReportList(monthCalendar.SelectionRange.Start, monthCalendar.SelectionRange.End));
            weeklyReport.setTitleText("Weekly Sales Report");
            weeklyReport.Show();
        }

        private void BtnMonthlyReport_Click(object sender, EventArgs e)
        {
            Report monthlyReport = new Report(List.ReportList(monthCalendar.SelectionRange.Start, monthCalendar.SelectionRange.End));
            monthlyReport.setTitleText("Monthly Sales Report");
            monthlyReport.Show();
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {

        }
    }
}
