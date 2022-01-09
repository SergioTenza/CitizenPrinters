using CitizenPrinters.Core.Models.CitizenPrinters;
using CitizenPrinters.Core.Models.Printers;
using Microsoft.Extensions.Logging;

namespace CitizenPrinters.Core.Services
{
    public partial class PrinterService : IPrinterService
    {
        private CitizenPrinter? citizenPrinter;
        public Printer? Printer => GetPrinter();

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

        private Printer? GetPrinter() => citizenPrinter.Printer ?? null;
    }
}
