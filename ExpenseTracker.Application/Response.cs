using System;
using System.ComponentModel;

namespace ExpenseTracker.Application
{
    public class Response<T>
    {
        public bool Success { get; set; }

        [DefaultValue(null)]
        public T Data { get; set; }
        public string ErrorMsg { get; set; }
        public Exception Exception { get; set; }
        public string ExceptionIdentifier { get; set; }

        public Response(T data, bool success = true)
        {
            Success = success;
            Data = data;
        }

        public Response(string errorMsg, Exception exception, bool success = false)
        {
            Success = success;
            ErrorMsg = errorMsg;
            Exception = exception;
            ExceptionIdentifier = Guid.NewGuid().ToString();
        }
    }
}
