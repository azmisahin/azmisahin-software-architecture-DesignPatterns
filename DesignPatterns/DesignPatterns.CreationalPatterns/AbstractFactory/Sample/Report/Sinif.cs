namespace DesignPatterns.CreationalPatterns.AbstractFactory.Sample
{
    public class Sinif : RaporBase
    {
        public override string Goster()
        {
            return GetType().ToString();
        }
    }

    public class SinifFactory : RaporFactory
    {
        public override RaporBase Olustur()
        {
            return new Sinif();
        }
    }
}
