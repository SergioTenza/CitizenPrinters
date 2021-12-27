using CitizenPrinters.Core.Vb.x86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Models.Printer
{
    public class CY_x64 : Printer
    {
        private ClassForCY_x64 classForCY_X64;
        public CY_x64()
        {
            classForCY_X64 = new();
        }
    }
}
