using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdmin2
{
    internal class CapacityExceededException : ApplicationException
    {
        public CapacityExceededException(string message) : base(message) { }
    }
}
