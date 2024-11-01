using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_CsvReader.Services.Interfaces;

namespace Week4_CsvReader.Services
{
    public class CsvSorter : ICsvSorter
    {
        public IEnumerable<dynamic> SortCsv(IEnumerable<dynamic> records, string sortColumn, bool ascending = true)
        {
            return ascending
                ? records.OrderBy(record => ((IDictionary<string, object>)record)[sortColumn])
                : records.OrderByDescending(record => ((IDictionary<string, object>)record)[sortColumn]);
        }
    }
}
