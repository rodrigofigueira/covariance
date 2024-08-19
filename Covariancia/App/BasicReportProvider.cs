namespace App;

public class BasicReportProvider : IReportProvider<Report>
{
    public Report GetReport()
    {
        return new Report { Title = "Basic Report" };
    }
}
