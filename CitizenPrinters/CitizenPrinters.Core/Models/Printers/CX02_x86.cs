﻿using CitizenPrinters.Core.Vb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Models.Printers
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
