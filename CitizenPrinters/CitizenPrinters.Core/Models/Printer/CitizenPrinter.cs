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

        private readonly bool Is64 = IntPtr.Size == 8;

        public CitizenPrinter(string name)
        {
            if (name == "CY")
            {
                if (Is64)
                {
                    Printer = (IPrinter?)Create(E_CitizenPrinters.CY_x64);
                    return;
                }
                Printer = (IPrinter?)Create(E_CitizenPrinters.CY_x86);
            }
            if (name == "CITIZEN CX-02")
            {
                throw new NotImplementedException();
            }
        }

        public Printer Create(E_CitizenPrinters e_CitizenPrinters)
        {
            var type = Type.GetType(typeof(Printer).Namespace + "." + e_CitizenPrinters.ToString(), throwOnError: false);

            if (type == null)
            {
                throw new InvalidOperationException(e_CitizenPrinters.ToString() + " is not a known dto type");
            }

            if (!typeof(Printer).IsAssignableFrom(type))
            {
                throw new InvalidOperationException(type.Name + " does not inherit from AbstractDto");
            }

            return (Printer)Activator.CreateInstance(type);
        }
    }
}
