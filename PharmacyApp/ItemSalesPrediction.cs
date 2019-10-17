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
    public partial class ItemSalesPrediction : Form
    {
        private string type;
        public ItemSalesPrediction(string type)
        {
            this.type = type;
            InitializeComponent();
            textBox1.Hide();
            button1.Hide();
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int prodId = Int32.Parse(txtProductID.Text);
            
            double? percentage = Prediction.PredictProductSales(prodId, type)*100;

            txtProductID.Hide();
            lblProductID.Hide();
            btnSave.Hide();
            button1.Show();
            textBox1.Show();

            if(percentage==null)
            {
                textBox1.Text = "Not enough data on item sales in past " + type.ToLower();
            }
           else if(percentage<25)
            {
                textBox1.Text = "Item's percentage of total sales in past " + type.ToLower() + " is " + percentage + "%. This indicates item is not so popular, so shouldn't be stocked a lot.";
            }
           else if(percentage>=50&&percentage<75)
            {
                textBox1.Text = "Item's percentage of total sales in past " + type.ToLower() + " is " + percentage + "%. This indicates item is moderately popular, so should be kept moderately stocked.";
            }
           else
            {
                textBox1.Text = "Item's percentage of total sales in past " + type.ToLower() + " is " + percentage + "%. This indicates item is popular, so should be stocked in large quantities.";
            }

            
           
        }

        private void ItemSalesPredictionInput_Load(object sender, EventArgs e)
        {

        }

        private void lblProductID_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
