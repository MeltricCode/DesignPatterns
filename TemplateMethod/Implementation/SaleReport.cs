using TemplateMethod.Abstract;

namespace TemplateMethod.Implementation;

public class SaleReport : ReportGenerator
{
    protected override void FetchData()
    {
        Console.WriteLine("Fetching sales data...");
    }

    protected override void ProcessData()
    {
        Console.WriteLine("Processing sales data...");
    }
}