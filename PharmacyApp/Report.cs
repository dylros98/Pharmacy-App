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
        public Report()
        {
            InitializeComponent();
        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {
           /* foreach ( s in )
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
