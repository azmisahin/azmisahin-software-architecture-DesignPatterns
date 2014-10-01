namespace DesignPatterns.CreationalPatterns.AbstractFactory.Report
{
    public class Assembler
    {
        public void Assemble(Factory factory)
        {
            Object obj = factory.Get();

            Screen(obj);
        }
        public void Screen(Object obj)
        {
            System.Console.WriteLine("██████████████████████████████████████R E P O R T█");
            System.Console.WriteLine
                (
                "Id: {0} Name: {1}", obj.Id, obj.Name
                );
            System.Console.WriteLine("═════════════════════════════════════════════════ ");
            System.Console.ReadLine();
        }
    }
}
