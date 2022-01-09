using CitizenPrinters.Core.Models.Printers;

namespace CitizenPrinters.Core.Services
{
    public interface IPrinterService
    {
        Printer? Printer { get; }
        bool InitializePrinter(string printerName);
        string GetStatus();
        int GetPortNumber(string printerName);
        string GetPortName();
    }
}
