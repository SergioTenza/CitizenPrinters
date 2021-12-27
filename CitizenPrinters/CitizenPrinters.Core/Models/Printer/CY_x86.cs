using CitizenPrinters.Core.Vb.x86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Models.Printer
{
    public class CY_x86 : Printer
    {
        private ClassForCY_x86 classForCX02_X86;
        public CY_x86()
        {
            classForCX02_X86 = new();
        }
    }
}
