using ExpenseTracker.Application;

namespace ExpenseTracker.API.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        // Throw the concerned exceptions from any place from the applications
        // If an exception happened, then log it using the nlog library
        // Frame the exception in the Response class method
        public void Hai()
        {
            var response = new Response<object>("Error msg", null, false);
        }
    }
}
