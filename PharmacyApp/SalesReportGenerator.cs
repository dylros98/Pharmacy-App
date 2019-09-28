using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp
{

    class SalesReportGenerator
    {
        public List<SalesReport> ReportList(bool monthly)
        {

            List<ProductRecord> products = DatabaseContext.GenerateAllProduct();
            int[] sales = DatabaseContext.GenerateSalesAmounts(monthly);
            List<SalesReport> report = new List<SalesReport>();
            int i = 0;

            foreach (ProductRecord record in products)
            {
                report.Add(new SalesReport()
                {
                    ProductID = record.ProductID,
                    Name = record.Name,
                    Quantity = sales[i],
                    Price = record.Price,
                    Total = Convert.ToDouble(sales[i]) * record.Price
                });
            }

            return report;

        }
    }
}
