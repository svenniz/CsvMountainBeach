namespace Week4_CsvReader.Services.Interfaces
{
    public interface ICsvPrinter
    {
        void PrintCsv(IEnumerable<dynamic> records);
    }
}