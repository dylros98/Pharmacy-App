using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_App
{
    public partial class Form1 : Form
    {
        private DatabaseContext context;
        public Form1()
        {
            InitializeComponent();
            context = new DatabaseContext();
            Console.WriteLine(context.GetAllSales()[0].Product);
            Console.WriteLine("hi");
        }

        private void ProgramBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
