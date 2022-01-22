using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenPrinters.Core.Models.Exceptions
{
    public class PrinterServiceException : Exception
    {
        public PrinterServiceException(Exception innerException)
            :base("PrinterService Exception. Please contact support.",innerException)
        { }
    }
}
