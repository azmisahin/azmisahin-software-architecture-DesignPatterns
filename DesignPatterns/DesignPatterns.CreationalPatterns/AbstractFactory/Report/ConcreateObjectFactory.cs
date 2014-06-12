namespace DesignPatterns.CreationalPatterns.AbstractFactory.Report
{
    public class ConcreateObjectFactory:Factory
    {
        public override Object Get()
        {
            return new ConcreateObject();
        }
    }
}
