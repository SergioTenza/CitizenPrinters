using CitizenPrinters.Core.Vb.x86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Models.Printer
{
    public class CyPrinter : IPrinter
    {
        private ClassForCY_x86 x86;
        private ClassForCY_x64 x64;
        private bool Is64 = IntPtr.Size == 4;

        public object Cy = null;

        public CyPrinter()
        {
            Cy = Is64 ? this.x86 = new() : this.x64 = new();
        }
    }
}
