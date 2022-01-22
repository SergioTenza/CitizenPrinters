using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Models.Exceptions
{
    public class PrinterServiceValidationNullException : Exception
    {
        public PrinterServiceValidationNullException()
            : base ("The printer name cannot be null or empty.")
        { }
    }
}
