using System;
using System.Collections.Generic;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Sample
{
    /// <summary>
    /// Extend Abstract
    /// Kalıtım
    /// </summary>
    public class Ogrenci : RaporBase
    {
        private DateTime from;
        private DateTime to;

        private TimeSpan Length;

        public Ogrenci()
        {
            from = DateTime.Now.AddDays(-7);
            to = DateTime.Now;
        }
        public Ogrenci(DateTime from, DateTime to)
        {
            this.from = from;
            this.to = to;
        }

        public override string Goster()
        {
            Length = to - from;
            return string.Format("Left : {0} for {1}", Length, GetType().ToString());
        }
    
    }

    public class OgrenciFactory : RaporFactory
    {
        private Ogrenci _ogrenci;
        public override RaporBase Olustur()
        {
            return _ogrenci;
        }
        public OgrenciFactory()
        {
            _ogrenci = new Ogrenci();
        }
        public OgrenciFactory(DateTime from, DateTime to)
        {
            _ogrenci = new Ogrenci(from,to);
        }
        
    }
}