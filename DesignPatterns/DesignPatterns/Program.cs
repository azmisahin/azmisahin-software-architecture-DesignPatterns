using DesignPatterns.Api.FluentInterface;
namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Reports reports = new Reports();
            Reports userReports = new Reports(Reports.ReportTypes.User);
            System.Console.ReadLine();

            var ReportSelect = Fluent.Start()
                .Type(new Reports(Reports.ReportTypes.Base))
                .Assemble();
            System.Console.ReadLine();

        }
    }
}
