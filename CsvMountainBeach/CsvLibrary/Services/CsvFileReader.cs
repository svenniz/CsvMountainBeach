using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using Week4_CsvReader.Services.Interfaces;

namespace Week4_CsvReader.Services
{
    public class CsvFileReader : ICsvFileReader
    {
        public IEnumerable<dynamic> ReadCsv(string filePath, Func<dynamic, bool> filter = null)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found: {filePath}");
                yield break;
            }
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture);
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, configuration))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    var record = csv.GetRecord<dynamic>();
                    if (filter == null || filter(record))
                    {
                        yield return record;
                    }
                }
            }
        }
        public IEnumerable<dynamic> ReadFilteredCsv(string filePath, string columnName, string value)
        {
            return ReadCsv(filePath).Where(record =>
            ((IDictionary<string, object>)record)[columnName].ToString()
            .Equals(value, StringComparison.OrdinalIgnoreCase)); // Apply filter
        }
    }
}
