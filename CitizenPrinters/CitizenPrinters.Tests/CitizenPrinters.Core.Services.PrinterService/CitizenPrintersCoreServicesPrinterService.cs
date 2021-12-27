using CitizenPrinters.Core.Services;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CitizenPrintersTests
{
    public class CitizenPrintersCoreServicesPrinterService
    {   
        private PrinterService printerService;

        [SetUp]
        public void Setup()
        {

            var logger = Mock.Of<ILogger<PrinterService>>();
            printerService = new PrinterService(logger);
        }

        [Test]
        public void ShouldCreateInstanceOfCyPrinterClassAndSetupPrinterName()
        {

            /*
            * What: Uses PrinterService to get Dll for selected printer
            * Where: Selected Printer is CY
            * When: after user selects a printer in combobox
            */

            //Given
            string printerName = "CY";

            //When
            Assert.DoesNotThrow( ()=> printerService.InitializePrinter(printerName));

            //Then
            Assert.IsNotNull(printerService.Printer);

        }
    }
}