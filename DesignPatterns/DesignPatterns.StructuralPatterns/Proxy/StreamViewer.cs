using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Proxy
{
    public class StreamViewer:iViewer<System.IO.Stream>
    {
        public override System.IO.Stream View(string fullPath)
        {
            System.IO.Stream result = default(System.IO.Stream);
            return result;
        }
    }
}
