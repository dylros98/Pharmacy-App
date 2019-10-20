using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.MemoryMappedFiles;
using CsvHelper;

namespace PharmacyApp
{

    class CsvReportGenerator
    {

        private List<SalesReport> Reports;

        public void GenerateCsv(List<SalesReport> salesReport)
        {
            using (var stream = new StreamWriter("PharmacyApp\\Reports\\Report.csv"))
            using (var csv = new CsvWriter(stream))
            {
                csv.WriteRecords(salesReport);
            }
        }

        public List<SalesReport> OpenCsv()
        {
            using (var reader = new StreamReader("PharmacyApp\\Reports\\Report.csv"))
            using (var csvReader = new CsvReader(reader))
            {
                Reports = csvReader.GetRecords<SalesReport>().ToList();
            }
            return Reports;
        }

    }
}
