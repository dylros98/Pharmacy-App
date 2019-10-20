using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp
{
    class SalesReportGenerator
    {
        public List<SalesReport> ReportList(DateTime startDate, DateTime endDate)
        {
            List<ProductRecord> products = ProductDatabase.GenerateAllProduct();
            List<SalesReport> report = new List<SalesReport>();

            foreach (ProductRecord record in products)
            {
                report.Add(new SalesReport()
                {
                    ProductID = record.ProductID,
                    Name = record.Name,
                    Quantity = SalesDatabase.GenerateSalesAmount(record.ProductID, startDate, endDate),
                    Price = record.Price,
                    Total = Convert.ToDouble(SalesDatabase.GenerateSalesAmount(record.ProductID, startDate, endDate)) * record.Price
                });
            }
            return report;
        }
    }
}
