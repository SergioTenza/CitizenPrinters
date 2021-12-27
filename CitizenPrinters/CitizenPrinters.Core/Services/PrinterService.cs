using CitizenPrinters.Core.Models.Printer;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Services
{
    public class PrinterService : IPrinterService
    {
        private CitizenPrinter citizenPrinter;
        public CitizenPrinter Printer => citizenPrinter;
        
        private readonly ILogger<PrinterService> logger;

        public PrinterService(ILogger<PrinterService> logger)
        {   
            this.logger = logger;
        }

        public string GetPortName()
        {
            throw new NotImplementedException();
        }

        public int GetPortNumber(string printerName)
        {
            throw new NotImplementedException();
        }

        public string GetStatus()
        {
            throw new NotImplementedException();
        }

        public bool InitializePrinter(string printerName)
        {
            citizenPrinter = new CitizenPrinter(printerName);
            return Printer is not null;
        }
    }
}
