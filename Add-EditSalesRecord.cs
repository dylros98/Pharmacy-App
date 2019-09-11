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
    public partial class Add_EditSalesRecord : Form
    {
        public Add_EditSalesRecord()
        {
            InitializeComponent();
        }

        private void Add_EditSalesRecord_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
