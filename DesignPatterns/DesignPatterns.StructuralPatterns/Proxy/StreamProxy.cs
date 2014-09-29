using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Proxy
{
    public class StreamProxy:StreamViewer
    {
        private StreamViewer streamViewer;
        public override System.IO.Stream View(string fullPath)
        {
            return  (streamViewer == null ? new StreamViewer() : streamViewer).View(fullPath);            
        }
    }
}
