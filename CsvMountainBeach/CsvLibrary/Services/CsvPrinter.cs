using System.Collections.Generic;
using System.Linq;
using Week4_CsvReader.Services.Interfaces;

namespace Week4_CsvReader.Services
{
    public class CsvPrinter : ICsvPrinter
    {
        public void PrintCsv(IEnumerable<dynamic> records)
        {
            if (records == null || !records.Any())
            {
                Console.WriteLine("No records to print.");
                return;
            }

            // Extract headers from the first record
            var headers = GetHeaders(records.First());
            Console.WriteLine(string.Join(", ", headers)); // Print headers

            // Print each record
            foreach (var record in records)
            {
                PrintRecord(record, headers); // Print record values
            }
        }
        private IEnumerable<string> GetHeaders(dynamic record)
        {
            return ((IDictionary<string, object>)record).Keys;
        }
        private void PrintRecord(dynamic record, IEnumerable<string> headers)
        {
            var values = headers.Select(header => ((IDictionary<string, object>)record)[header]);
            Console.WriteLine(string.Join(", ", values)); // Print values of each record
        }
    }
}