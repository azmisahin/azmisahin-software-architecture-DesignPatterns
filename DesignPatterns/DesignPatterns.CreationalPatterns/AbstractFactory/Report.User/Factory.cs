namespace DesignPatterns.CreationalPatterns.AbstractFactory.Report.User
{
    public class Factory:Report.Factory
    {
        public override Report.Object Get()
        {
            return new Object();
        }
    }
}
