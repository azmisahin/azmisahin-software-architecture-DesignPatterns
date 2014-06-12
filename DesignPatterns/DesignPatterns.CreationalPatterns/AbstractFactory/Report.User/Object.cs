namespace DesignPatterns.CreationalPatterns.AbstractFactory.Report.User
{
    public class Object:Report.Object
    {
        public override int Id
        {
            get { return 1; }
        }
        public override string Name
        {
            get { return "Kullanıcı Raporu"; }
        }
    }
}
