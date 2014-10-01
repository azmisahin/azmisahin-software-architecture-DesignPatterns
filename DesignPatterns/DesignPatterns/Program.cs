namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Reports reports = new Reports();
            Reports userReports = new Reports(Reports.ReportTypes.User);

            var reportPrint = Core<Reports>.Report()
                .Type(Reports.ReportTypes.Base)
                .Type(Reports.ReportHardware.Screen)
                .Assemble();
                
        }
    }
}
