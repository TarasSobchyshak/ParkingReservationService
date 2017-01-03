using System;

namespace PRS.WebApi.Exceptions
{
    public class ApiAuthorizationException : Exception
    {
        public ApiAuthorizationException()
            : base()
        { }

        public ApiAuthorizationException(string message)
            : base(message)
        { }

        public ApiAuthorizationException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}