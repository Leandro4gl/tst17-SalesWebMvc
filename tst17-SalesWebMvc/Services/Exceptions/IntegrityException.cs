using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tst17_SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
