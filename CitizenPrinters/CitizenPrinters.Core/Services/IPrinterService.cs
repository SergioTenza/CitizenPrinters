using CitizenPrinters.Core.Models.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Services
{
    public interface IPrinterService
    {
        CitizenPrinter Printer { get;}
        bool InitializePrinter(string printerName);
        string GetStatus();
        int GetPortNumber(string printerName);
        string GetPortName();
    }
}
