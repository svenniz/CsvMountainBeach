namespace Week4_CsvReader.Services.Interfaces
{
    public interface ICsvSorter
    {
        IEnumerable<dynamic> SortCsv(IEnumerable<dynamic> records, string sortColumn, bool ascending = true);
    }
}