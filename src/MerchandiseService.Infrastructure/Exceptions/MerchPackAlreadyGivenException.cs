using System;

namespace MerchandiseService.Infrastructure.Exceptions
{
    public class MerchPackAlreadyGivenException : Exception
    {
        public string Message { get; }

        public MerchPackAlreadyGivenException(string message) : base(message)
        {
            Message = message;
        }
    }
}