namespace Week4_CsvReader.Services.Interfaces
{
    public interface ICsvExporter
    {
        void ExportToCsv(IEnumerable<dynamic> records, string outputFilePath);
    }
}