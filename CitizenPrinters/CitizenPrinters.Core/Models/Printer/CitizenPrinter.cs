using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Models.Printer
{
    public class CitizenPrinter : ICitizenPrinter
    {
        public string Name { get; set; }
        public string PortName { get; set; }
        public int PortNumber { get; set; }
        public IPrinter Printer { get; set; }
    }
}
