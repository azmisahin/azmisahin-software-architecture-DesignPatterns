namespace DesignPatterns
{
    using DesignPatterns.CreationalPatterns.AbstractFactory.Report;
    class Reports
    {
        public enum ReportHardware
        {
            Screen,
            Printer
        }
        public enum ReportTypes
        {
            Base,
            User
        }
        public Reports()
        {
            Factory factory = new ConcreateObjectFactory();
            new Assembler().Assemble(factory);
        }
        public Reports(ReportTypes reportTypes)
        {
            Factory factory = null;
            switch (reportTypes)
            {
                default:
                    factory = new ConcreateObjectFactory();                    
                    break;

                case ReportTypes.Base:
                    factory = new ConcreateObjectFactory();                    
                    break;

                case ReportTypes.User:
                    factory = new DesignPatterns.CreationalPatterns.AbstractFactory.Report.User.Factory();                    
                    break;
            }
            new Assembler().Assemble(factory);
        }
    }
}