using System;

namespace Cv3PKM.RocketAPI.Exceptions
{
    public class InvalidResponseException : Exception
    {
        public InvalidResponseException()
        {}

        public InvalidResponseException(string message)
            : base(message)
        { }
    }
}