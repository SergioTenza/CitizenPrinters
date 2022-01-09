using CitizenPrinters.Core.Vb.x86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Models.Printers
{
    public class CX02W_x86 : Printer
    {
        private ClassForCX02W_x86 classForCX02W_X86;
        public CX02W_x86()
        {
            classForCX02W_X86 = new();
        }
    }
}
