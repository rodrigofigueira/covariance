namespace App;

public interface IReportProvider<out TReport>
{
    TReport GetReport();
}
