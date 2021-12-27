using CitizenPrinters.Core.Services;
using NUnit.Framework;

namespace CitizenPrinters.Tests.CitizenPrinters.Core.Services.PrinterService.Tests
{
    public class CitizenPrintersCoreServicesPrinterService
    {
        Moq.Mock<IPrinterService> _mockPrinterService;

        [SetUp]
        public void Setup()
        {
            _mockPrinterService = new Moq.Mock<IPrinterService>();
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
            Assert.DoesNotThrow( ()=> _mockPrinterService.Object.InitializePrinter(printerName));

            //Then
            Assert.IsNotNull(_mockPrinterService.Object.Printer);

        }
    }
}