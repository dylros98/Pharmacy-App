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
            using (Database databaseForm = new Database())
            {
                this.Hide();
                databaseForm.FormClosed += new FormClosedEventHandler(DatabaseForm_FormClosed);
                
                if (databaseForm.ShowDialog() == DialogResult.Cancel)
                {
                    databaseForm.Close();
                    this.Show();
                }
            }
        }

        void DatabaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void BtnGenerateReports_Click(object sender, EventArgs e)
        {
            using (DateSelection dateForm = new DateSelection())
            {
                this.Hide();
                dateForm.FormClosed += new FormClosedEventHandler(DateForm_FormClosed);

                if (dateForm.ShowDialog() == DialogResult.Cancel)
                {
                    dateForm.Close();
                    this.Show();
                }
            }
        }

        void DateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
