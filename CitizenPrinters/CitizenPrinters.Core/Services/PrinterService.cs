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
        private readonly ICitizenPrinter citizenPrinter;
        private readonly ILogger<PrinterService> logger;

        public PrinterService(ICitizenPrinter citizenPrinter, ILogger<PrinterService> logger)
        {
            this.citizenPrinter = citizenPrinter;
            this.logger = logger;
        }

        public CitizenPrinter Printer => throw new NotImplementedException();

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
            throw new NotImplementedException();
        }
    }
}
