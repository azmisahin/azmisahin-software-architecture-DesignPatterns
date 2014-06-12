using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    using DesignPatterns.CreationalPatterns.AbstractFactory.Report;
    class Reports
    {
        public enum ReportTypes
        {
            Base
        }
        public Reports()
        {
            Factory factory = new ConcreateObjectFactory();
            new Assembler().Assemble(factory);
        }
    }
}