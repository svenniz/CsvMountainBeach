// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using Week4_CsvReader.Services;
using Week4_CsvReader.Services.Interfaces;

Console.WriteLine("Hello, World!");

var fileIn = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CsvData\\mountains_vs_beaches_preferences.csv");
var fileOut = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CsvData\\output.csv");

ICsvFileReader fileReader = new CsvFileReader();
ICsvPrinter printer = new CsvPrinter();
ICsvExporter exporter = new CsvExporter();

var records = fileReader.ReadCsv(fileIn);
var filteredSkiRecords = fileReader.ReadFilteredCsv(fileIn, "Preferred_Activities", "skiing");
printer.PrintCsv(filteredSkiRecords);
exporter.ExportToCsv(filteredSkiRecords, fileOut);