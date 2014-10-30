using System;
namespace DesignPatterns.CreationalPatterns.AbstractFactory.Sample
{
    public abstract class RaporBase
    {        
        public abstract string Goster();
    }
    public abstract class RaporFactory
    {
        public abstract RaporBase Olustur();
    }
}