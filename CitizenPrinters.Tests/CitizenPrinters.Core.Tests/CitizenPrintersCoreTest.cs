using CitizenPrinters.Core;
using CitizenPrinters.Core.Models.CitizenPrinters;
using CitizenPrinters.Core.Models.Printers;
using NUnit.Framework;
using System;

namespace CitizenPrintersTests
{
    public class CitizenPrintersCoreTest
    {
        private CitizenPrinter citizenPrinter;
        

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ShouldCreateClassForCyPrinterAndNotThrowException()
        {

            /*
            * What: Try to instantiate a new Printer Class
            * Where: On Main Form StartUp
            * When: A printer is selected on Combobox
            */

            //Given
            string name = "CY";


            //When
            Assert.DoesNotThrow( () => citizenPrinter = new CitizenPrinter(name) );


            //Then
            Assert.IsNotNull(citizenPrinter);
            if (IntPtr.Size == 8)
            {
                Assert.IsInstanceOf<CY_x64>(citizenPrinter.Printer);
            }
            else if (IntPtr.Size == 4)
            {
                Assert.IsInstanceOf<CY_x86>(citizenPrinter.Printer);
            }
            
        }

        [Test]
        public void ShouldCreateClassForCX02PrinterAndNotThrowException()
        {

            /*
            * What: Try to instantiate a new Printer Class
            * Where: On Main Form StartUp
            * When: A printer is selected on Combobox
            */

            //Given
            string name = "CITIZEN CX-02";


            //When
            Assert.DoesNotThrow(() => citizenPrinter = new CitizenPrinter(name));


            //Then
            Assert.IsNotNull(citizenPrinter);
            if (IntPtr.Size == 8)
            {
                Assert.IsInstanceOf<CX02_x64>(citizenPrinter.Printer);
            }
            else if (IntPtr.Size == 4)
            {
                Assert.IsInstanceOf<CX02_x86>(citizenPrinter.Printer);
            }

        }

        [Test]
        public void ShouldCreateClassForCX02WPrinterAndNotThrowException()
        {

            /*
            * What: Try to instantiate a new Printer Class
            * Where: On Main Form StartUp
            * When: A printer is selected on Combobox
            */

            //Given
            string name = "CITIZEN CX-02W";


            //When
            Assert.DoesNotThrow(() => citizenPrinter = new CitizenPrinter(name));


            //Then
            Assert.IsNotNull(citizenPrinter);
            if (IntPtr.Size == 8)
            {
                Assert.IsInstanceOf<CX02W_x64>(citizenPrinter.Printer);
            }
            else if (IntPtr.Size == 4)
            {
                Assert.IsInstanceOf<CX02W_x86>(citizenPrinter.Printer);
            }

        }
    }
}