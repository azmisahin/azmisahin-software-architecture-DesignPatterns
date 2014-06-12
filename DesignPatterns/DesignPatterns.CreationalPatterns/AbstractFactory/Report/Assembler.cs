namespace DesignPatterns.CreationalPatterns.AbstractFactory.Report
{
    public class Assembler
    {
        public void Assemble(Factory factory)
        {
            Object obj = factory.Get();
            System.Console.WriteLine
                (
                "Id: {0} Name: {1}", obj.Id, obj.Name
                );
        }
    }
}
