namespace App;

public class ReportConsumer
{
    public void PrintReport(IReportProvider<Report> provider)
    {
        var report = provider.GetReport();
        Console.WriteLine($"Report Title: {report.Title}");
    }
}
