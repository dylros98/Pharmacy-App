using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp
{
    private DatabaseContext db;

    class SalesReportGenerator
    {
        db = new DatabaseContext();
    }

    private List<SalesReport> ReportList(){

        List<ProductRecord> products = db.GenerateAllProduct();
        int[] sales = db.GenerateSalesAmounts();
        List<SalesReport> report = new SalesReport();
        int i = 0;

        foreach (ProductRecord record in products)
        {
            report.add(new SalesReport(){
                ProductID = record.ProductID;
                Name = record.Name;
                Quantity = sales[i];
                Price = record.Price;
                Total = Quanitity * Price;
            });
        }

        return report;

    }
}
