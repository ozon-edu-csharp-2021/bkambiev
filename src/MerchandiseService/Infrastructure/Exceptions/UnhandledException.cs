using System;

namespace MerchandiseService.Infrastructure.Exceptions
{
    public class UnhandledException : Exception
    {
        public string ExceptionType { get; }
        public string Message { get; }
        public string StackTrace { get; }

        public UnhandledException(string exceptionType, string message, string stackTrace) : base(message)
        {
            ExceptionType = exceptionType;
            Message = message;
            StackTrace = stackTrace;
        }
    }
}