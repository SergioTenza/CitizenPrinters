﻿using CitizenPrinters.Core.Vb.x86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Models.Printer
{
    public class CX02_x64 : Printer
    {
        private ClassForCX02_x64 classForCX02_X64;
        public CX02_x64()
        {
            classForCX02_X64 = new();
        }
    }
}