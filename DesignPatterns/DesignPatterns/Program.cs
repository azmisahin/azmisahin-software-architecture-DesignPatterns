namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Reports reports = new Reports();
            Reports userReports = new Reports(Reports.ReportTypes.User);
            System.Console.ReadLine();
        }
    }
}
