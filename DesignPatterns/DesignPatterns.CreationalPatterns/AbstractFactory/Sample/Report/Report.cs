using System;
namespace DesignPatterns.CreationalPatterns.AbstractFactory.Sample
{
    /// <summary>
    /// Raporlar / Fluent 
    /// </summary>
    public class Report
    {
        public static ReportsFluent Hazirla()
        {
            return new ReportsFluent();
        }
    }

    /// <summary>
    /// Propert
    /// </summary>
    public interface iReportsFluent
    {
        iReportsFluent FactorySet(RaporFactory factory);
        RaporFactory Init();
    }
    public class ReportsFluent : iReportsFluent
    {
        private RaporFactory _raporFactory;
        public RaporFactory Init()
        {
            return _raporFactory;
        }
        public iReportsFluent FactorySet(RaporFactory factory)
        {
            _raporFactory = factory;
            Task();
            return this;
        }

        /// <summary>
        /// Rapor Çalışma Zamanı İşlemleri
        /// </summary>
        private void Task()
        {
            Console.WriteLine(_raporFactory.GetType().ToString());
        }
    }
}