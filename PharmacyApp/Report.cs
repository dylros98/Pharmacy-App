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
                tlpDataRecords.Controls.Add(new Label() { Text = s.ProductID.ToString() }, 0, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.Name.ToString() }, 1, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.Quantity.ToString() }, 2, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.Price.ToString() }, 3, rowIndex);
                tlpDataRecords.Controls.Add(new Label() { Text = s.Total.ToString() }, 4, rowIndex);
                rowIndex++;
            }
        }
    }
}
