namespace App
{
    public class DetailedReportProvider : IReportProvider<DetailedReport>
    {
        public DetailedReport GetReport()
        {
            return new DetailedReport()
            {
                Title = "Detailed Report",
                Details = "Detailed information about the report"
            };
        }
    }
}
