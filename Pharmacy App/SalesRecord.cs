using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_App
{
    /// <summary>
    /// Sales record object that represents a sales record from the database
    /// </summary>
    public class SalesRecord
    {
        public int SaleID { get; set; }

        public string Product { get; set; }

        public DateTime DateSold { get; set; }

        public string Category { get; set; }
    }
}
