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
    public partial class EditSalesRecord : Form
    {
        private SalesRecord saleRecord;

        public SalesRecord SaleRecord
        {
            set
            {
                saleRecord = value;
            }
        }

        public EditSalesRecord()
        {
            InitializeComponent();
        }

        private void EditSalesRecord_Load(object sender, EventArgs e)
        {
            txtProductID.Text = saleRecord.ProductID.ToString();
            txtQuantity.Text = saleRecord.Quantity.ToString();
            txtDateSold.Text = saleRecord.DateSold.ToString("dd-MMM-yy");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int saleId = saleRecord.SaleID;
            int prodId = Int32.Parse(txtProductID.Text);
            int quan = Int32.Parse(txtQuantity.Text);
            string dt = txtDateSold.Text;

            DatabaseContext.EditSalesRecord(saleId, prodId, quan, dt);

            Close();
        }
    }
}
