using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    class TempException : ApplicationException
    {
        public TempException() { }
        public TempException(string message) : base(message) { }
        public TempException(string message, Exception inner):base(message, inner) { }
    }
}
