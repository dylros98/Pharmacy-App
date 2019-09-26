using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp
{
    /// <summary>
    /// Sales record object that represents a sales record from the database
    /// </summary>
    public class SalesReport
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public double Total { get; set; }
    }
}