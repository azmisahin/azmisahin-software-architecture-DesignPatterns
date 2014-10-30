using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DesignPatterns.CreationalPatterns.AbstractFactory.Sample;
namespace DesignPatterns.Test
{
    [TestClass]
    public class AbstractFactory
    {
        DateTime from = DateTime.Now.AddDays(-10);
        DateTime to = DateTime.Now;
        [TestMethod]
        public void TestMethod1()
        {
            var ogrenci1 = Report.Hazirla()
                .FactorySet(new OgrenciFactory())
                .Init()
                .Olustur()
                .Goster();
        }

        [TestMethod]
        public void TestMethod2()
        {
            var ogreni2 = Report.Hazirla()
                .FactorySet(new OgrenciFactory(from, to))
                .Init()
                .Olustur()
                .Goster();
        }

        [TestMethod]
        public void TestMethod3()
        {
            from = DateTime.Now.AddDays(-20);
            var ready = Report.Hazirla();
            var fact = ready
                .FactorySet(new OgrenciFactory(from: from, to: to))
                .Init();
            var task = fact.Olustur();
            var report = task.Goster();

        }

        [TestMethod]
        public void TestMethod4()
        {
            var TurkceSinav = Sinav
                  .Init(new TurkceFactory())
                  .Baslat();
            var MatematikSinav = Sinav
                .Init(new MatematikFactory())
                .Baslat();

        }

    }
}
