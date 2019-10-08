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

        private void BtnViewDatabase_Click(object sender, EventArgs e)
        {
            Database databaseForm = new Database();
            databaseForm.Show();
        }

        private void BtnGenerateReports_Click(object sender, EventArgs e)
        {
            DateSelection dateForm = new DateSelection();
            dateForm.Show();
        }
    }
}
