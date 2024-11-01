using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_CsvReader.Services.Interfaces;

namespace Week4_CsvReader.Services
{
    public class CsvExporter : ICsvExporter
    {
        public void ExportToCsv(IEnumerable<dynamic> records, string outputFilePath)
        {
            using (var writer = new StreamWriter(outputFilePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(records);
            }
        }
    }
}
