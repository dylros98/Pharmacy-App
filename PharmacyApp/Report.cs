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
    public partial class Report : Form
    {
        private int rowIndex = 1;
        private List<SalesReport> reportList;

        public Report(List<SalesReport> List)
        {
            reportList = List;
            InitializeComponent();
        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {
           foreach (SalesReport s in reportList)
            {
                GUIFunctions.addNewReportRecord(tlpDataRecords, rowIndex, s);
                rowIndex++;
            }
        }
    }
}
