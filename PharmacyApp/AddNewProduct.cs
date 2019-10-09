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
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductRecord newProductRecord = new ProductRecord()
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = Double.Parse(txtPrice.Text),
                Category = txtCategory.Text
            };
             
            DatabaseContext.AddNewProduct(newProductRecord);

            Close();
        }

        private void lblProductID_Click(object sender, EventArgs e)
        {

        }
    }
}
