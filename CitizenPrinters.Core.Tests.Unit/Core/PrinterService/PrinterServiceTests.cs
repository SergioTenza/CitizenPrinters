using CitizenPrinters.Core.Models.CitizenPrinters;
using CitizenPrinters.Core.Models.Printers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CitizenPrinters.Core.Tests.Unit.Core.PrinterService
{
    public class PrinterServiceTests
    {
        [Theory]
        [InlineData("CITIZEN CX-02")]
        [InlineData("CITIZEN CX-02W")]
        [InlineData("CY")]
        public void ShouldCreateClassForCyPrinterAndNotThrowException(
            string printerName)
        {

            /*
            * What:
            * Where:
            * When:
            */

            //Given
            CitizenPrinter citizenPrinter = new CitizenPrinter(printerName);
            var type = citizenPrinter.Printer.GetType();
            //When


            //Then
            Assert.NotNull(citizenPrinter.Printer);
            Assert.True(IsSameTypeAs(citizenPrinter.Printer));
            
        }

        private bool IsSameTypeAs(Printer printer)
        {
            return printer.GetType().BaseType == typeof(Printer);
             
        }
    }
}
