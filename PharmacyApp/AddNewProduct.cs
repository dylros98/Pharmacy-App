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
        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductRecord newProductRecord = new ProductRecord()
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = Double.Parse(txtPrice.Text),
                Category = txtCategory.Text
            };
             
            ProductDatabase.AddNewProduct(newProductRecord);

            Close();
        }
    }
}
