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
            List<SalesReport> report = new List<SalesReport>();

            foreach (ProductRecord record in products)
            {
                report.Add(new SalesReport()
                {
                    ProductID = record.ProductID,
                    Name = record.Name,
                    Quantity = DatabaseContext.GenerateSalesAmount(record.ProductID, monthly),
                    Price = record.Price,
                    Total = Convert.ToDouble(DatabaseContext.GenerateSalesAmount(record.ProductID, monthly)) * record.Price
                });
            }
            DatabaseContext.SaveSalesReport(report);
            return report;

        }
    }
}
