using CitizenPrinters.Core.Models.CitizenPrinters;
using CitizenPrinters.Core.Models.Printers;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CitizenPrinters.Core.Tests.Unit.Core.PrinterService
{
    public class PrinterServiceTests
    {
        [Fact]
        public void ShouldReturnNullAndFalseOnBadPrinterName()
        {

            /*
            * What:
            * Where:
            * When:
            */

            //Given
            string printerName = "Epson";
            bool result = false;
            var logger = Mock.Of<ILogger<CitizenPrinters.Core.Services.PrinterService>>();
            CitizenPrinters.Core.Services.PrinterService citizenPrinter = new(logger);

            //When
            result = citizenPrinter.InitializePrinter(printerName);

            //Then
            Assert.Null(citizenPrinter.Printer);
            Assert.False(result);
        }

       
    }
}
