using TemplateMethod.Abstract;

namespace TemplateMethod.Implementation;

public class InventoryReport : ReportGenerator
{
    protected override void FetchData()
    {
        Console.WriteLine("Fetching inventory data...");
    }

    protected override void ProcessData()
    {
        Console.WriteLine("Processing inventory data...");
    }

    protected override void ExportDate()
    {
        Console.WriteLine("Exporting inventory report to Excel...");
        Console.WriteLine("--------------------------------------");

    }
}