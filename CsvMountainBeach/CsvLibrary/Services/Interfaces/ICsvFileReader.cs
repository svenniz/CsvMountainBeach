namespace Week4_CsvReader.Services.Interfaces
{
    public interface ICsvFileReader
    {
        IEnumerable<dynamic> ReadCsv(string filePath, Func<dynamic, bool> filter = null);
        IEnumerable<dynamic> ReadFilteredCsv(string filePath, string columnName, string value);
    }
}