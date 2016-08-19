using System;

namespace Cv3PKM.RocketAPI.Exceptions
{
    public class AccountNotVerifiedException : Exception
    {
        public AccountNotVerifiedException(string message) : base(message)
        {
            
        }
    }
}