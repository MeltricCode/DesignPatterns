namespace TemplateMethod.Abstract;

public abstract class ReportGenerator
{
    public void GenerateReport()
    {
        FetchData();
        ProcessData();
        ExportDate();
    }
    
    protected abstract void FetchData();
    protected abstract void ProcessData();

    protected virtual void ExportDate()
    {
        Console.WriteLine("Exporting report to PDF (default)...");
        Console.WriteLine("------------------------------------");
    }
}