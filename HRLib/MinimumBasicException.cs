
using System;

namespace HRLib
{     public class MinimumBasicException : ApplicationException
        {
        public MinimumBasicException()
            : base("Basic salary must be at least Rs. 5000.") { }

        public MinimumBasicException(string message)
            : base(message) { }
    }
}


