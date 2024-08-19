using App;

IReportProvider<Report> basicReportProvider = new BasicReportProvider();
IReportProvider<Report> detailedReportProvider = new DetailedReportProvider();

ReportConsumer consumer = new();
consumer.PrintReport(basicReportProvider);
consumer.PrintReport(detailedReportProvider);

Console.ReadKey();