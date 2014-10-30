namespace DesignPatterns.CreationalPatterns.AbstractFactory.Sample
{
    public class Ogretmen : RaporBase
    {
        public override string Goster()
        {
            return GetType().ToString();
        }
    }
    public class OgretmenFactory : RaporFactory
    {
        public override RaporBase Olustur()
        {
            return new Ogretmen();
        }
    }
}