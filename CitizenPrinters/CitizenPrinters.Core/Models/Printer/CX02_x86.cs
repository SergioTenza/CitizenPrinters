using CitizenPrinters.Core.Vb.x86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Models.Printer
{
    public class CX02_x86 : Printer
    {
        private ClassForCX02_x86 classForCX02_X86;
        public CX02_x86()
        {
            classForCX02_X86 = new();
        }
    }
}
