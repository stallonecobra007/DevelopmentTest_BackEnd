namespace DevelopmentTest
{
    public interface ICalculateStatistics
    {
        double Mean(string values);
        double Median(string values);
        string Mode(string values);
    }
}