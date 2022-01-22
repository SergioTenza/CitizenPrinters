using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Models.Exceptions
{
    public class PrinterServiceValidationException : Exception
    {
        public PrinterServiceValidationException()
            :base("Validation error on PrinterService. Check parameters and try again.")
        { }
    }
}
