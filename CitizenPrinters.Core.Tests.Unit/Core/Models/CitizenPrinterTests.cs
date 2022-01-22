using CitizenPrinters.Core.Models.CitizenPrinters;
using CitizenPrinters.Core.Models.Printers;
using System;
using Xunit;

namespace CitizenPrinters.Core.Tests.Unit.Core.Models
{
    public class CitizenPrinterTests
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
            //When


            //Then
            Assert.NotNull(citizenPrinter.Printer);
            Assert.True(IsSameTypeAs(citizenPrinter.Printer));
            Assert.True(IsInstanceOf(citizenPrinter.Printer));

        }
        private bool IsSameTypeAs(Printer printer)
        {
            return printer.GetType().BaseType == typeof(Printer);
        }

        private bool IsInstanceOf(Printer printer)
        {
            return IntPtr.Size == 8 ?
                printer.GetType() == typeof(CY_x64) ||
                printer.GetType() == typeof(CX02_x64) ||
                printer.GetType() == typeof(CX02W_x64)
                :
                printer.GetType() == typeof(CY_x86) ||
                printer.GetType() == typeof(CX02_x86) ||
                printer.GetType() == typeof(CX02W_x86);
        }
    }
}
