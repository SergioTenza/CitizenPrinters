using CitizenPrinters.Core.Models.Printer;
using CitizenPrinters.Core.Vb.x86;
using NUnit.Framework;

namespace CitizenPrinters.Tests.CitizenPrinters.Core.Vb.x86
{
    public class CitizenPrintersCoreVbx86Test
    {
        private CitizenPrinter citizen;
        private ClassForCY_x64 ClassCompare;

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ShouldCreateClassForCyx64AndNotThrowAnyException()
        {

            /*
            * What: Try to instantiate a new Printer Class
            * Where: On Main Form StartUp
            * When: A printer is selected on Combobox
            */

            //Given
            string name = "CY";

            //When
            citizen = new CitizenPrinter(name);
            ClassCompare = new();

            //Then
            Assert.IsNotNull(citizen);
            Assert.IsTrue(citizen.GetType() == ClassCompare.GetType());

        }
    }
}