using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp
{
    /// <summary>
    /// Product record object that represents a product from the database
    /// </summary>
    public class ProductRecord
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Double { get; set; }

        public string Category { get; set; }
    }
}
