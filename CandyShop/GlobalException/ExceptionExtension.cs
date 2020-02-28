using CandyShop.GlobalException.CustomException;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;

namespace CandyShop.GlobalException
{
    public static class ExceptionExtension
    {
        public static void ConfigureExceptionMiddleware(this IApplicationBuilder app, ILoggerFactory logger)
        {
            app.UseMiddleware<ExceptionMiddleware>(logger);
        }
    }
}
