using System;

namespace PRS.Business.Exceptions
{
    public class SecurityException : Exception
    {
        public SecurityException()
            : base()
        { }

        public SecurityException(string message)
            : base(message)
        { }

        public SecurityException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
