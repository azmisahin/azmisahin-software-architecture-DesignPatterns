using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Sample
{
    public interface SinavBase
    {}

    public interface SinavFactory
    {
        SinavBase Baslat();
    }

  
    //
    public class Sinav
    {
        public static SinavFactory Init(SinavFactory factory)
        { return factory;}

    }

    /// <summary>
    /// Implement
    /// SınavBase Uygula
    /// </summary>
    public class Matematik :SinavBase
    { }

    public class MatematikFactory : SinavFactory
    {
        public SinavBase Baslat()
        {
            return new Matematik();
        }
    }

    ///
    public class Turkce : SinavBase
    { }

    public class TurkceFactory : SinavFactory
    {
        public SinavBase Baslat()
        {
            return new Turkce();
        }
    }

    // Abstract based app
    
    //public abstract class SinavBase
    //{
    //    public SinavBase()
    //    {
    //    }
    //}

    //public abstract class SinavFactoy
    //{
    //    public abstract SinavBase Baslat();
    //}

    //public class Sinav 
    //{
    //    public static SinavFactoy Init(SinavFactoy factory)
    //    { return factory; }

    //}

    //public class Matematik : SinavBase
    //{ }
    //public class MatematikFactory : SinavFactoy
    //{
    //    public override SinavBase Baslat()
    //    {
    //        return new Matematik();
    //    }
    //}

    //public class Turkce : SinavBase
    //{ }

    //public class TurkceFactory : SinavFactoy
    //{
    //    public override SinavBase Baslat()
    //    {
    //        return new Turkce();
    //    }
    //}
}
