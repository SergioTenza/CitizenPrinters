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
            bool result = false;

            //When
            Assert.DoesNotThrow( ()=> result = printerService.InitializePrinter(printerName));

            //Then
            Assert.IsNotNull(printerService.Printer);
            Assert.IsTrue(result);

        }

        [Test]
        public void ShouldReturnNullAndFalseOnBadPrinterName()
        {

            /*
            * What: Uses PrinterService to get Dll for selected printer
            * Where: Selected Printer is CY
            * When: after user selects a printer in combobox
            */

            //Given
            string printerName = "Epson";
            bool result = false;

            //When
            Assert.DoesNotThrow(() => result = printerService.InitializePrinter(printerName));

            //Then
            Assert.IsNull(printerService.Printer);
            Assert.IsFalse(result);

        }
    }
}